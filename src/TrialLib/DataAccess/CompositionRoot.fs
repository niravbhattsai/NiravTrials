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
let getEmployee = EmployeeRepository.getEmployee getContext
let addEmployee = EmployeeRepository.addEmployee getContext
let updateEmployee = EmployeeRepository.updateEmployee getContext
let deleteEmployee = EmployeeRepository.deleteEmployee getContext