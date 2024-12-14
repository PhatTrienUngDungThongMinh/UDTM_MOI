using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeliveryReceiptDAL
    {
        private readonly DBDataContext db;

        public DeliveryReceiptDAL()
        {
            db = new DBDataContext();
        }
        

        public List<DeliveryReceipt> GetAllDeliveryReceipts()
        {
            return db.DeliveryReceipts.ToList();
        }

        public void AddDeliveryReceipt(DeliveryReceipt receipt, BindingList<DeliveryReceiptDetail> deli)
        {
            try
            {
                db.DeliveryReceipts.InsertOnSubmit(receipt);
                db.SubmitChanges(); 

                foreach (var detail in deli)
                {
                    detail.ReceiptID = receipt.id; 
                    db.DeliveryReceiptDetails.InsertOnSubmit(detail);
                }
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while adding delivery receipt: {ex.Message}");
                throw; 
            }
        }

        public void UpdateDeliveryReceipt(DeliveryReceipt receipt)
        {
            var existingReceipt = db.DeliveryReceipts.SingleOrDefault(r => r.id == receipt.id);
            if (existingReceipt != null)
            {
                existingReceipt.DeliveryDate = receipt.DeliveryDate;
                existingReceipt.Notes = receipt.Notes;
                existingReceipt.SupplierID = receipt.SupplierID;
                existingReceipt.EmployeeID = receipt.EmployeeID;
                existingReceipt.Status = receipt.Status;
                existingReceipt.createdAt = receipt.createdAt;
                existingReceipt.updatedAt = receipt.updatedAt;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("DeliveryReceipt not found");
            }
        }

        public void DeleteDeliveryReceipt(int receiptId)
        {
            var receipt = db.DeliveryReceipts.SingleOrDefault(r => r.id == receiptId);
            if (receipt != null)
            {
                db.DeliveryReceipts.DeleteOnSubmit(receipt);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("DeliveryReceipt not found");
            }
        }
    }
}
