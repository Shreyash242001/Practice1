import React from "react";
import axios from "axios";

class Register extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      email: "",
      password: "",
    };
  }

  Handler = (e) => {
    this.setState({ [e.target.name]: e.target.value });
  };

  SubmitHandler = (e) => {
    e.preventDefault();
    console.log(this.state);

    // custom API
    //.Net Core
    axios.post("http://localhost:5293/api/user", this.state)
    // Spring Boot
    //axios.post("http://localhost:8080/api/user", this.state)
      .then((res) => {
        console.log(res);
      });
  };

  render() {
    const { email, password } = this.state;

    return (
      <div style={{"margin" : "50px"}}>
        <div className="RegisterForm">
          <br /><br />
          <form onSubmit={this.SubmitHandler} style={{"margin" : "50px"}}>
            <div className="form-outline mb-4" style={{"margin" : "50px"}}>
              <input onChange={this.Handler} value={email} placeholder="Email" name="email" type="text" id="form2Example1" className="form-control" />
            </div>

            <div className="form-outline mb-4" style={{"margin" : "50px"}}>
              <input onChange={this.Handler} value={password} placeholder="Password" name="password" type="text" id="form2Example2" className="form-control" />
            </div>

            <div className="row mb-4">
              <div className="col d-flex justify-content-center">
              <div className="form-check">
              <input className="form-check-input" type="checkbox" value="" id="form2Example31" checked />
              <label className="form-check-label" htmlFor="form2Example31"> Remember me </label>
            </div>
           </div>

          <div className="col">
            <a href="#!">Forgot password?</a>
          </div>
          </div>

          <button type="submit" className="btn btn-primary btn-block mb-4">Register</button>
        </form>

        </div>
      </div>
    );
  }
}

export default Register;



