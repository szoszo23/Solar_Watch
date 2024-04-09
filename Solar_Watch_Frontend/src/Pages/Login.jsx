import React from "react";
import { useNavigate } from "react-router-dom";

function Login() {
    const navigate = useNavigate();
    async function handleSubmit(event) {
        
    }
    return(<div>
        <h2>Login</h2>
        <form className="card" onSubmit={handleSubmit}>
            <label>Email:</label>
            <br/>
            <input type="email" name="email"/>
            <br/>
            <label>Password:</label>
            <br/>
            <input type="password" name="password"/>
            <br/>
            <br/>
            <button type="submit">Login</button>
        </form>
    </div>)
}

export default Login;