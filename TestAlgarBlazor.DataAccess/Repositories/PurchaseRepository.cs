using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAlgarBlazor.Model;
using Newtonsoft.Json;
using System.Security.Principal;

namespace TestAlgarBlazor.DataAccess.Repositories;

public class PurchaseRepository : IPurchaseRepository
{
    public String ConnectionString;
    public PurchaseRepository(string connectionString)
    {
        ConnectionString = connectionString;
    }

    protected SqlConnection dbConnect()
    {


        return new SqlConnection(ConnectionString);
    }
    public int InsertPurchase(string _customerName, string _customerAddress)
    {
        var db = dbConnect();

        var result = db.Query<int>("INSERT_PURCHASE", new { customerName = _customerName, CustomerAddress = _customerAddress }, commandType: CommandType.StoredProcedure).FirstOrDefault();

        return result;
    }
    public bool InsertPurchaseDetails(PurchaseDetails details)
    {
        var db = dbConnect();
        var ret = true;
        try
        {
            db.Query<int>("INSERT_PURCHASE_DETAILS", new { productId = details.productId, purchaseId = details.purchaseId, quantity = details.quantity, unitPrice = details.unitPrice, TotalPrice = details.totalPrice }, commandType: CommandType.StoredProcedure); return true;
          
        }
        catch (Exception)
        {
            ret = false;
        }

        return ret;
    }
    public string getPurchaseInfoById(int purchaseId)
    {
        var db = dbConnect();

        var result = db.Query<PurchaseApiInfo>("GET_PURCHASE_INFO_BY_ID", new { PurchaseId = purchaseId }, commandType: CommandType.StoredProcedure).ToList();

        var data = JsonConvert.SerializeObject(result);

        return data;
    }

}