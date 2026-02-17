import { useState, useEffect } from 'react'
import './App.css'

const API_URL = 'http://localhost:5005/Children'

function App() {
  const [children, setChildren] = useState([])
  const [loading, setLoading] = useState(true)
  const [error, setError] = useState(null)

  useEffect(() => {
    fetch(API_URL)
      .then((res) => {
        if (!res.ok) throw new Error(`HTTP ${res.status}`)
        const contentLength = res.headers.get('content-length')
        if (res.status === 204 || contentLength === '0') return []
        return res.json()
      })
      .then((data) => {
        setChildren(data || [])
        setLoading(false)
      })
      .catch((err) => {
        setError(err.message)
        setLoading(false)
      })
  }, [])

  return (
    <div className="app">
      <h1>Daycare Children</h1>

      {loading && <p>Loading...</p>}
      {error && <p className="error">Error: {error}</p>}

      {!loading && !error && children.length === 0 && (
        <p>No children found.</p>
      )}

      {children.length > 0 && (
        <table>
          <thead>
            <tr>
              <th>First Name</th>
              <th>Middle Name</th>
              <th>Last Name</th>
              <th>Date of Birth</th>
              <th>Gender</th>
            </tr>
          </thead>
          <tbody>
            {children.map((child) => (
              <tr key={child.correlation_id}>
                <td>{child.first_name}</td>
                <td>{child.middle_name}</td>
                <td>{child.last_name}</td>
                <td>{new Date(child.date_of_birth).toLocaleDateString()}</td>
                <td>{child.gender}</td>
              </tr>
            ))}
          </tbody>
        </table>
      )}
    </div>
  )
}

export default App
