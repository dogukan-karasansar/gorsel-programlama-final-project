using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spor_kayit_sistemi.Models
{
    internal class Customer
    {
        public string Name
        { get; set; }
        public string Surname
        { get; set; }
        public string TC
        { get; set; }
        public string Address
        { get; set; }
        public string BirthDay
        { get; set; }
        public string tel
        { get; set; }
        public string startDate
        { get; set; }
        public string EndDate
        { get; set; }
        public float price
        { get; set; }
        public string PaymentType
        { get; set; }
        public string CardNumber
        { get; set; }
        public int Installment
        { get; set; }

        public Customer(string name, string surname, string tC, string address, string birthDay, string tel, string startDate, string endDate, float price, string paymentType, string cardNumber, int ınstallment)
        {
            Name = name;
            Surname = surname;
            TC = tC;
            Address = address;
            BirthDay = birthDay;
            this.tel = tel;
            this.startDate = startDate;
            EndDate = endDate;
            this.price = price;
            PaymentType = paymentType;
            CardNumber = cardNumber;
            Installment = ınstallment;
        }

        public Customer()
        {

        }

        public static implicit operator List<object>(Customer v)
        {
            throw new NotImplementedException();
        }
    }
}
