﻿using System;
using System.Collections.Generic;

namespace eCommerce.Datas.Entities
{
    public partial class Order
    {
        public Order()
        {
            Pembayarans = new HashSet<Pembayaran>();
            Pengirimen = new HashSet<Pengiriman>();
        }

        public int IdOrder { get; set; }
        public int IdKeranjang { get; set; }
        public DateOnly TglTransaksi { get; set; }
        public decimal JumlahBayar { get; set; }
        public int IdAlamat { get; set; }
        public int IdCustomer { get; set; }
        public int Status { get; set; }
        public string? Catatan { get; set; }

        public virtual Alamat IdAlamatNavigation { get; set; } = null!;
        public virtual Customer IdCustomerNavigation { get; set; } = null!;
        public virtual Keranjang IdKeranjangNavigation { get; set; } = null!;
        public virtual StatusOrder StatusNavigation { get; set; } = null!;
        public virtual ICollection<Pembayaran> Pembayarans { get; set; }
        public virtual ICollection<Pengiriman> Pengirimen { get; set; }
    }
}