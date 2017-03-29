CREATE procedure [dbo].[AddNewEmpDetails]  
(  
   @Name varchar (50),  
   @City varchar (50),  
   @Address varchar (50)  
)  
as  
begin  
   Insert into Employee(Name,City,Address)values(@Name,@City,@Address)  
End