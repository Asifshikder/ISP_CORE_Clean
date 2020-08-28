using Dapper;
using ISPCore.Application.Purchase.Queries.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ISPCore.Application.Purchase.Queries
{
    public class GetPurchaseListQueryHandler : IRequestHandler<Queries.GetPurchaseList, List<PurchaseVM>>
    {
        public GetPurchaseListQueryHandler(DbConnection connection)
        {
            _connection = connection;
        }
        private readonly DbConnection _connection;

        public string Subject { get; set; }
        public int SupplierID { get; set; }
        public int PublishStatus { get; set; }
        public string InvoicePrefix { get; set; }
        public string InvoiceID { get; set; }
        public DateTime IssuedAt { get; set; }
        public string SupplierNoted { get; set; }
        public double SubTotal { get; set; }
        public int DiscountType { get; set; }
        public double DiscountPercentOrFixedAmount { get; set; }
        public double DiscountAmount { get; set; }
        public double Discount { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }
        public double PurchasePayment { get; set; }
        public int? ResellerID { get; set; }
        public int PurchaseStatus { get; set; }

        public async Task<List<PurchaseVM>> Handle(Queries.GetPurchaseList request, CancellationToken cancellationToken)
        {
            var query = $"select Id, Subject,SupplierID,PublishStatus,InvoicePrefix,InvoiceID,IssuedAt,SupplierNoted,SubTotal,DiscountType,DiscountPercentOrFixedAmount,DiscountAmount,Discount,Tax,Total,PurchasePayment,ResellerID,PurchaseStatus" +"" +
                        $"where \"IsDeleted\" = False";

            var data = await _connection.QueryAsync<PurchaseVM>(query);
            return data.ToList();
        }
    }
}
