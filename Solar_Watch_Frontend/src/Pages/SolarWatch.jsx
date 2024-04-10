import React, {useState} from "react";
import { useNavigate } from "react-router-dom";

function SolarWatch() {
    const navigate = useNavigate();
    const currentDate = new Date();
    const [sunriseTime, setSunriseTime] = useState("");
    const [sunsetTime, setSunsetTime] = useState("");
    const [date, setDate] = useState("");
    const [city, setCity] = useState("");
    const [hideResult, setHideResult] = useState(true);
    const [loading, setLoading] = useState(true);

    async function handleSubmit(event) {
        event.preventDefault();
        setLoading(false);
        try {
            const response = await fetch(`api/Solar/GetSunriseSunset?city=${city}&date=${date}`,
                {
                    method: "GET",
                    credentials: "include",
                    headers: {
                        "Content-Type": "application/json"
                    },
                })
            const data = await response.json();
            console.log(data)
            setSunriseTime(data.sunrise);
            setSunsetTime(data.sunset);
            setLoading(true);
            setHideResult(false);
        } catch (e) {
            console.error(e);
        }

    }
    
    function clearForm() {
        setCity("");
        setDate(formattedDate);
        setSunriseTime("");
        setSunsetTime("");
        setHideResult(true);
        // clear the form inputs
        document.getElementsByName("city")[0].value = "";
        document.getElementsByName("date")[0].value = formattedDate;
    }
    return(<div>
            <h2>SolarWatch</h2>
            <div className="card" hidden={hideResult === true ? false : true}>
                <form onSubmit={handleSubmit}>
                    <label>City name:</label>
                    <br/>
                    <input
                        required={true}
                        type="text"
                        name="city"
                        onChange={(e) => setCity(e.target.value)}
                        autoComplete="off"
                    />
                    <br/>
                    <label>Date:</label>
                    <br/>
                    <input
                        type="date"
                        name="date"
                        value={date}
                        onChange={(e) => setDate(e.target.value)}
                    />
                    <br/>
                    <br/>
                    <button type="submit">Search</button>
                </form>
            </div>
            <div hidden={loading}>
                <h3>Loading...</h3>
            </div>
            <div className="card" hidden={hideResult}>
                <h3>Sunrise and Sunset times in:</h3>
                <h3>{city}</h3>
                <h3>at:</h3>
                <h3>{date}</h3>
                <h3>Sunrise time (UTC):</h3>
                <h3>{sunriseTime}</h3>
                <h3>Sunset time (UTC):</h3>
                <h3>{sunsetTime}</h3>
                <button type="button" onClick={() => clearForm()}>
                    Clear
                </button>
            </div>
            <button type="button" onClick={() => navigate("/")}>
                Cancel
            </button>
        </div>
    )
}

export default SolarWatch;