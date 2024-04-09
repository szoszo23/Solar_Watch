import React from "react";

function Register() {

    
    function handleSubmit(event){
        
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