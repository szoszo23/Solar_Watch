import React from "react";
import { useNavigate } from "react-router-dom";

function Login() {
    const navigate = useNavigate();
    async function handleSubmit(event) {
        event.preventDefault();
        const email = event.target.email.value;
        const password = event.target.password.value;
        try {
            const response = await fetch("/api/Auth/Login", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify({
                    email,
                    password,
                }),
            });
            const data = await response.json();
            if ("error" in data) {
                throw new Error(data.error);
            }
            alert("Login successful!");
            sessionStorage.setItem("token", data.token);
            navigate("/");
        } catch (error) {
            alert(error);
            console.error("Error:", error);
        }
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