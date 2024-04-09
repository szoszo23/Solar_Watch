import { Outlet, Link } from "react-router-dom";
import './App.css'

function App() {
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
