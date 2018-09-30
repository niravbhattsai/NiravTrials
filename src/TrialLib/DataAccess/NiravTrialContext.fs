namespace TrialLib.DataAccess
open System
open Microsoft.EntityFrameworkCore
open Microsoft.EntityFrameworkCore.Storage.ValueConversion
open TrialLib.Model
open System.Collections.ObjectModel
open Microsoft.EntityFrameworkCore

type NiravTrialContext = 
    inherit DbContext

    new() ={inherit DbContext()}
    new (options: DbContextOptions<NiravTrialContext>)={inherit DbContext(options)}

    [<DefaultValue>]
    val mutable employees:DbSet<Employee>
    member x.Employees
        with get()=x.employees
        and set v= x.employees <-v
        