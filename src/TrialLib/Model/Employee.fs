namespace TrialLib.Model

open System.Collections.Generic
open System.ComponentModel.DataAnnotations.Schema
open System.ComponentModel.DataAnnotations.Schema

type EmployeeId = int


[<Table("employee") >]
type [<CLIMutable>] Employee = {
    [<Column("id")>]
    Id :EmployeeId
    [<Column("firstname")>]
    FirstName:string
    [<Column("lastname")>]
    LastName:string
    [<Column("addressline1")>]
    AddressLine1:string 
    [<Column("addressline2")>]
    AddressLine2:string 
    }