﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeliveryReceiptBLL
    {
        private readonly DeliveryReceiptDAL deliveryReceiptDAL = new DeliveryReceiptDAL();

        public DeliveryReceiptBLL()
        {
            
        }

        public List<DeliveryReceipt> GetAllDeliveryReceipts()
        {
            return deliveryReceiptDAL.GetAllDeliveryReceipts();
        }
        public void UpdateDeliveryReceiptStatus(int id, string status)
        {
            deliveryReceiptDAL.UpdateDeliveryReceiptStatus(id, status);
        }
            public void AddDeliveryReceipt(DeliveryReceipt receipt, BindingList<DeliveryReceiptDetail> de)
        {
            deliveryReceiptDAL.AddDeliveryReceipt(receipt,de);
        }

        public void UpdateDeliveryReceipt(DeliveryReceipt receipt)
        {
            if (receipt.DeliveryDate == default(DateTime))
            {
                throw new ArgumentException("Ngày giao hàng không hợp lệ.");
            }

            deliveryReceiptDAL.UpdateDeliveryReceipt(receipt);
        }

        public void DeleteDeliveryReceipt(int receiptId)
        {
            deliveryReceiptDAL.DeleteDeliveryReceipt(receiptId);
        }
    }
}
