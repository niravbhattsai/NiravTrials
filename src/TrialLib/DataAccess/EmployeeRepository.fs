namespace TrialLib.DataAccess
open TrialLib.DataAccess
open TrialLib.Model
open System.Linq
open Microsoft.EntityFrameworkCore

module EmployeeRepository =
    let getEmployees (context:NiravTrialContext)=
        context.Employees.ToList()
    let getEmployee (context:NiravTrialContext) id =
        query {
            for employee in context.Employees do
                where (employee.Id = id)
                select employee
                exactlyOne
        } |> (fun x -> if box x = null then None else Some x)

    let addEmployee (context : NiravTrialContext) (entity: Employee) =
        context.Employees.Add(entity) |> ignore
        context.SaveChanges true |> ignore

    let updateEmployee (context: NiravTrialContext) (entity: Employee) =
        let currentEntry = context.Employees.Find(entity.Id)
        context.Entry(currentEntry).CurrentValues.SetValues(entity)
        context.SaveChanges true |> ignore
    
    let deleteEmployee (context: NiravTrialContext) (entity: Employee)=
        context.Employees.Remove entity |> ignore
        context.SaveChanges true |> ignore

