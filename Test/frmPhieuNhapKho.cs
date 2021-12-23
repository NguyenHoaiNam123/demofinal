﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Test
{
    public partial class frmPhieuNhapKho : Form
    {
        public frmPhieuNhapKho()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM PhieuNhapHang WHERE maHang = @maHang";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("maHang", txtMaHang.Text);
            cmd.Parameters.AddWithValue("tenHang", cbbTenHang.Text);
            cmd.Parameters.AddWithValue("soLuong", nmSoLuong.Text);
            cmd.Parameters.AddWithValue("giaNhapHang", txtGiaNhapHang.Text);
            cmd.Parameters.AddWithValue("tongTien", txtTongTien.Text);
            cmd.Parameters.AddWithValue("ngayNhap", dtpNgayNhap.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void frmPhieuNhapKho_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["User"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        SqlConnection con;
        public void HienThi()
        {
            string sqlSELECT = "SELECT *FROM PhieuNhapHang";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dsPhieuNhapKho.DataSource = dt; 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO PhieuNhapHang VALUES (@maHang, @tenHang, @soLuong, @giaNhapHang, @tongTien, @ngayNhap)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, con);
            cmd.Parameters.AddWithValue("maHang", txtMaHang.Text);
            cmd.Parameters.AddWithValue("tenHang", cbbTenHang.Text);
            cmd.Parameters.AddWithValue("soLuong", nmSoLuong.Text);
            cmd.Parameters.AddWithValue("giaNhapHang", txtGiaNhapHang.Text);
            cmd.Parameters.AddWithValue("tongTien", txtTongTien.Text);
            cmd.Parameters.AddWithValue("ngayNhap", dtpNgayNhap.Text);

            cmd.ExecuteNonQuery();
            HienThi();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE PhieuNhapHang SET tenHang = @tenHang, soLuong = @soLuong, giaNhapHang = @giaNhapHang, tongTien = @tongTien, ngayNhap = @ngayNhap WHERE maHang = @maHang";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("maHang", txtMaHang.Text);
            cmd.Parameters.AddWithValue("tenHang", cbbTenHang.Text);
            cmd.Parameters.AddWithValue("soLuong", nmSoLuong.Text);
            cmd.Parameters.AddWithValue("giaNhapHang", txtGiaNhapHang.Text);
            cmd.Parameters.AddWithValue("tongTien", txtTongTien.Text);
            cmd.Parameters.AddWithValue("ngayNhap", dtpNgayNhap.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void dsPhieuNhapKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dsPhieuNhapKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
