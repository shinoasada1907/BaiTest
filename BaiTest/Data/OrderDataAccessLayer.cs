using BaiTest.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BaiTest.Data
{
    public class OrderDataAccessLayer
    {
        string connectionString = ConnectionString.ConnectionName;
        public IEnumerable<Order> GetAllOrder()
        {
            List<Order> lstOrder = new List<Order>();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllOrder", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Order order = new Order();
                    order.Id = Convert.ToInt32(reader["Id"]);
                    order.SalesOrder = reader["SalesOrder"].ToString();
                    order.SalesOrderItem = reader["SalesOrderItem"].ToString();
                    order.WorkOrder = reader["WorkOrder"].ToString();
                    order.ProductID = reader["ProductID"].ToString();
                    order.ProductDescription = reader["ProductDescription"].ToString();
                    order.OrderQuantity = reader["OrderQuantity"].ToString();
                    order.OrderStatus = reader["OrderStatus"].ToString();
                    order.Times_tamp = Convert.ToDateTime(reader["Times_tamp"]);

                    lstOrder.Add(order);
                }
                cnn.Close();
            }
            return lstOrder;
        }

        public void AddOrder(Order order)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddOrder", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SalesOrder", order.SalesOrder);
                cmd.Parameters.AddWithValue("@SalesOrderItem", order.SalesOrderItem);
                cmd.Parameters.AddWithValue("@WorkOrder", order.WorkOrder);
                cmd.Parameters.AddWithValue("@ProductID", order.ProductID);
                cmd.Parameters.AddWithValue("@ProductDescription", order.ProductDescription);
                cmd.Parameters.AddWithValue("@OrderQuantity", order.OrderQuantity);
                cmd.Parameters.AddWithValue("@OrderStatus", order.OrderStatus);
                cmd.Parameters.AddWithValue("@Times_tamp", order.Times_tamp);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public void UpdateOrder(Order order)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateOrder", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", order.Id);
                cmd.Parameters.AddWithValue("@SalesOrder", order.SalesOrder);
                cmd.Parameters.AddWithValue("@SalesOrderItem", order.SalesOrderItem);
                cmd.Parameters.AddWithValue("@WorkOrder", order.WorkOrder);
                cmd.Parameters.AddWithValue("@ProductID", order.ProductID);
                cmd.Parameters.AddWithValue("@ProductDescription", order.ProductDescription);
                cmd.Parameters.AddWithValue("@OrderQuantity", order.OrderQuantity);
                cmd.Parameters.AddWithValue("@OrderStatus", order.OrderStatus);
                cmd.Parameters.AddWithValue("@Times_tamp", order.Times_tamp);

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public Order GetOrder(int Id)
        {
            Order order = new Order();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Orders WHERE Id= " + Id;
                SqlCommand cmd = new SqlCommand(sqlQuery, cnn);
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    order.Id = Convert.ToInt32(reader["Id"]);
                    order.SalesOrder = reader["SalesOrder"].ToString();
                    order.SalesOrderItem = reader["SalesOrderItem"].ToString();
                    order.WorkOrder = reader["WorkOrder"].ToString();
                    order.ProductID = reader["ProductID"].ToString();
                    order.ProductDescription = reader["ProductDescription"].ToString();
                    order.OrderQuantity = reader["OrderQuantity"].ToString();
                    order.OrderStatus = reader["OrderStatus"].ToString();
                    order.Times_tamp = Convert.ToDateTime(reader["Times_tamp"]);
                }
                cnn.Close();
            }
            return order;
        }

        public List<Order> SearchOrder(string SalesOrder)
        {

            List<Order> l = new List<Order>();
            l.Clear();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Orders WHERE SalesOrder like '%" + SalesOrder + "%'";
                SqlCommand cmd = new SqlCommand(sqlQuery, cnn);
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Order order = new Order();
                    order.Id = Convert.ToInt32(reader["Id"]);
                    order.SalesOrder = reader["SalesOrder"].ToString();
                    order.SalesOrderItem = reader["SalesOrderItem"].ToString();
                    order.WorkOrder = reader["WorkOrder"].ToString();
                    order.ProductID = reader["ProductID"].ToString();
                    order.ProductDescription = reader["ProductDescription"].ToString();
                    order.OrderQuantity = reader["OrderQuantity"].ToString();
                    order.OrderStatus = reader["OrderStatus"].ToString();
                    order.Times_tamp = Convert.ToDateTime(reader["Times_tamp"]);
                    l.Add(order);
                }
                cnn.Close();
            }
            return l;
        }

        public void DeleteOrder(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteOrder", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
