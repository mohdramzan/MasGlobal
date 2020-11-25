import React, {useEffect,useState} from 'react'
import logo from './logo.svg';
import './App.css';


function App() {
   let [employees,setEmployees] = useState([])
   let [loading, setLoading] = useState(false)
  /// we can use xios to do crud operation on the DOM..  sorry for not creating the best structure in UI, 
  // it is just a demo;  
const getCalculatedEmployees = async () => {
  setLoading(true)
  let url = 'http://localhost:60335/api/employees'

  let data = await fetch(url).then((data) => {
       return  data.json();
  });
  setEmployees(data);
  setLoading(false)
 }
  return (
    <div className="App">
      <button onClick={getCalculatedEmployees}>Get Employees</button>
        <table style={{"border":"1"}}>
          <tr>
            <th>Name</th>
            <th>Type</th>
            <th>Hourly Salary</th>
            <th>Monthly Salary</th>
            <th>Calculated Salary</th>
          </tr>
          <tbody>
            {loading && (<tr>Loading....</tr>)}
          {
          employees?.map(employee => {
              return <tr>
                <td>{employee.name}</td>
                <td>{employee.roleName}</td>
                <td>{employee.hourlySalary}</td>
                <td>{employee.monthlySalary}</td>
                <td>{employee.calculatedSalary}</td>

              </tr>
          })

        }
          </tbody>
        </table>
        
    </div>
  );
}

export default App;
