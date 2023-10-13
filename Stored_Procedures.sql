use Test
go

Create procedure spAddOrder(
	@SalesOrder nvarchar(255),
    @SalesOrderItem nvarchar(255),
    @WorkOrder nvarchar(255),
    @ProductID nvarchar(255),
    @ProductDescription nvarchar(255),
    @OrderQuantity decimal(18,2),
    @OrderStatus nvarchar(255),
    @Times_tamp datetime
)
as
begin
	Insert into Orders(SalesOrder,SalesOrderItem,WorkOrder,ProductID,ProductDescription,OrderQuantity,OrderStatus,Times_tamp)           
    Values (@SalesOrder,@SalesOrderItem,@WorkOrder,@ProductID,@ProductDescription,@OrderQuantity,@OrderStatus,@Times_tamp)     
end
go

Create procedure spUpdateOrder(
	@Id int,
	@SalesOrder nvarchar(255),
    @SalesOrderItem nvarchar(255),
    @WorkOrder nvarchar(255),
    @ProductID nvarchar(255),
    @ProductDescription nvarchar(255),
    @OrderQuantity decimal(18,2),
    @OrderStatus nvarchar(255),
    @Times_tamp datetime
)
as
begin
	Update Orders             
   set SalesOrder = @SalesOrder, 
   SalesOrderItem = @SalesOrderItem, 
   WorkOrder = @WorkOrder, 
   ProductID = @ProductID, 
   ProductDescription = @ProductDescription, 
   OrderQuantity = @OrderQuantity, 
   OrderStatus = @OrderStatus, 
   Times_tamp = @Times_tamp
   where Id=@Id      
end
go

create procedure spDeleteOrder(@Id int)
as
begin
	Delete from Orders where Id=@Id 
end
go

Create procedure spGetAllOrder        
as        
Begin        
    select *        
    from Orders     
    order by Id   
End  