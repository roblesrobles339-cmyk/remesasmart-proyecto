
import { useEffect, useState } from 'react'
import api from './services/api'
import './App.css'

function App() {
  const [weather, setWeather] = useState([])

  useEffect(() => {
    api.get('/WeatherForecast')
      .then((response) => {
        setWeather(response.data)
      })
  }, [])

  return (
    <main>
      <h1>RemesaSmart SV</h1>

      <section>
        <h2>Prueba de conexión con C#</h2>

        {weather.map((item, index) => (
          <p key={index}>
            {item.date} - {item.temperatureC}°C - {item.summary}
          </p>
        ))}
      </section>
    </main>
  )
}

export default App
