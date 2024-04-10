import { Outlet, Link, useLocation} from "react-router-dom";
import { useEffect, useState } from "react";
import './App.css'

function App() {
    const [user, setUser] = useState(null);
    const [email, setEmail] = useState(null);
    const location = useLocation();

    useEffect(() => {
        async function fetchData() {
            try {
                const response = await fetch("/api/Auth/WhoAmI", {
                    method: "GET",
                    credentials: "include",
                    headers: {
                        "Content-Type": "application/json",
                    },
                });
                
                if(!response.ok) {
                    throw new Error("Network response was not ok")
                }
                const data = await response.json();
                console.log(data);
                if (data) {
                    setUser(data.userName);
                    setEmail(data.email);
                }
            } catch (error) {
                console.log("Error", error);
            }
        }
        fetchData();
    }, [location.pathname]);
    
    
    return (
        <div>
            <header className="App-header">
                <h1>Solar Watch</h1>
                <div className="Layout">
                    <nav>
                        <Link to="/">
                            <button type="button">Home</button>
                        </Link>
                        <Link to="/register">
                            <button type="button">Register</button>
                        </Link>
                        <Link to="/login">
                            <button type="button">Login</button>
                        </Link>
                        <Link to="/solar-watch">
                            <button type="button">Solar Watch</button>
                        </Link>
                    </nav>
                    <Outlet/>
                </div>
            </header>
        </div>
    )
}

export default App
