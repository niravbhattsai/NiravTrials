module CompostionRoot

open TrialLib.DataAccess
open Microsoft.EntityFrameworkCore
let configurePostgresContext = 
    ( fun () ->  
        let optionBuilder = new DbContextOptionsBuilder<NiravTrialContext>();
        optionBuilder.UseNpgsql("Host=localhost;Database=NiravTrial;Username=postgres;Password=sa") |> ignore
        new NiravTrialContext(optionBuilder.Options)
    )

let getContext = configurePostgresContext()
let getEmployees = EmployeeRepository.getEmployees getContext
let getEmployee = EmployeeRepository.getEmployee getContext
let addEmployee: TrialLib.Model.Employee->unit = EmployeeRepository.addEmployee getContext
let updateEmployee: TrialLib.Model.Employee->unit = EmployeeRepository.updateEmployee getContext
let deleteEmployee: TrialLib.Model.Employee->unit = EmployeeRepository.deleteEmployee getContext