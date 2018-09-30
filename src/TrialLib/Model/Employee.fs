namespace TrialLib.Model

type EmployeeId = int


type Employee() =
    member val Id :EmployeeId = 0 
    member val FirstName:string=""
    member val LastName:string=""
    member val AddressLine1:string = null
    member val AddressLine2:string = null