import React from "react";
import { useNavigate } from "react-router-dom";
function Register() {
    const navigate = useNavigate();
    
    async function handleSubmit(event){
        event.preventDefault();
        const userName = event.target.username.value;
        const email = event.target.email.value;
        const password = event.target.password.value;
        
        try {
            const response = await fetch("/api/Auth/Register",{
                method: "POST",
                headers:{
                    "Content-Type": "application/json"
                },
                body: JSON.stringify({email, userName, password})
            })
            const data = await response.json();
            if ("DuplicateEmail" in data) {
                throw new Error("Email already registered!");
            }
            if ("DuplicateUserName" in data) {
                throw new Error("Username already registered!");
            }
            alert("Registration successful!");
            navigate("/login");

        } catch (e) {
            alert("Registration failed!")
            console.error(e);
        }
        
    }
    return(<div className="registration">
        <form className="registrationForm" onSubmit={handleSubmit}>
            <label>Username:</label>
            <br></br>
            <input type="text" name="username"></input>
            <br></br>
            <label>Email:</label>
            <br></br>
            <input type="email" name="email"></input>
            <br></br>
            <label>Password:</label>
            <br></br>
            <input type="password" name="password"></input>
            <br></br>
            <button type="submit">Register</button>
        </form>
    </div>)
}

export default Register;