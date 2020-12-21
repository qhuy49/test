using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace testAPI.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult>  Index()
        {
            //using (var client = new HttpClient())
            //{
            //    //    client.BaseAddress = new Uri("http://demohoadon.minvoice.com.vn");
            //    //    var content = new FormUrlEncodedContent(new[]
            //    //    {
            //    //    new KeyValuePair<string, string>("username", "administrator"),
            //    //     new KeyValuePair<string, string>("password", "kythuat"),
            //    //      new KeyValuePair<string, string>("ma_dvcs", "VP")

            //    //});
            //    //    var result = await client.PostAsync("/api/Account/Login", content);
            //    //    string resultContent = await result.Content.ReadAsStringAsync();
            //    //    var obj = JObject.Parse(resultContent);
            //    //    var kq = obj["token"].ToString();
            //    //    if (kq != null)
            //    //    {
            //    //        System.Diagnostics.Debug.WriteLine(kq);
            //    //    }
            //    //WebClient client2 = new WebClient();
            //    //client2.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            //    //client2.Encoding = System.Text.Encoding.UTF8;
            //    //string tendangnhap = "administrator";
            //    //string matkhau = "kythuat";
            //    //string json = "{\"username\":\"" + tendangnhap + "\",\"password\":\"" + matkhau + "\",\"ma_dvcs\":\"VP\"}";
            //    //// 
            //    //string reslt = client2.UploadString("http://demohoadon.minvoice.com.vn/api/Account/Login", json);
            //    //JObject tk = JObject.Parse(reslt);
            //    //string kq = tk["token"].ToString();



            //    //    using (var client1 = new HttpClient())
            //    //    {
            //    //        client1.BaseAddress = new Uri("http://demohoadon.minvoice.com.vn");
            //    //        client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
            //    //        client1.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", kq);

            //    ////     var content1 = new FormUrlEncodedContent(new[]
            //    ////    {
            //    ////    new KeyValuePair<string, string>("username", "administrator"),
            //    ////     new KeyValuePair<string, string>("password", "kythuat"),
            //    ////      new KeyValuePair<string, string>("ma_dvcs", "VP")

            //    ////});
            //    //        var result1 = await client1.GetAsync("/api/System/GetDataReferencesByRefId?refId=RF00027");
            //    //        string resultContent1 = await result1.Content.ReadAsStringAsync();
            //    //        var obj1 = JObject.Parse(resultContent1);
            //    //        //double a = Math.Round();
            //    //        //System.Diagnostics.Debug.WriteLine(a);
            //    //        //WebClient client2 = new WebClient();
            //    //        //client2.Encoding = Encoding.UTF8;
            //    //        //client2.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            //    //        //client2.Headers.Add(HttpRequestHeader.Authorization, token);
            //    //    }

            //}
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client.Encoding = System.Text.Encoding.UTF8;
            string tendangnhap = "TEST";
            string matkhau = "123456";
            string json = "{\"username\":\"" + tendangnhap + "\",\"password\":\"" + matkhau + "\",\"ma_dvcs\":\"VP\"}";
            // 
            string reslt = client.UploadString("http://0303754648.minvoice.com.vn/api/Account/Login", json);
            JObject tk = JObject.Parse(reslt);
            string token = "Bear " + tk["token"].ToString() + ";VP";
            WebClient client2 = new WebClient();
            client2.Encoding = Encoding.UTF8;
            client2.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            client2.Headers.Add(HttpRequestHeader.Authorization, token);


            string invoice = "{\r\n  \"windowid\": \"WIN00187\",\r\n  \"data\": [\r\n    {\r\n      \"inv_InvoiceAuth_id\": \"773ccee2-95ba-4e42-b623-6790ae4057c6\",\r\n      \"inv_invoiceNumber\": \"0011276\",\r\n      \"inv_invoiceSeries\": \"QD/19E\",\r\n      \"mau_hd\": \"01GTKT0/001\",\r\n      \"inv_invoiceIssuedDate\": \"2020-11-02\",\r\n      \"inv_currencyCode\": \"VND\",\r\n      \"inv_exchangeRate\": 1,\r\n      \"ma_dt\": \"0003040\",\r\n      \"inv_buyerLegalName\": \"CHI NHÁNH TẠI TP.HCM CÔNG TY TNHH HỆ THỐNG THÔNG TIN FPT (TP. HÀ NỘI)\",\r\n      \"inv_buyerTaxCode\": \"0104128565-001\",\r\n      \"inv_buyerAddressLine\": \"Lô B3, Đường Sáng Tạo, Khu E - Office, KCX Tân Thuận, P. Tân Thuận Đông, Quận 7, TP.HCM , Việt Nam\",\r\n      \"inv_buyerEmail\": \"hoadondientu-fishcm@fpt.com.vn, danhdt5@fpt.com.vn, tranbq@fpt.com.vn, NhoNT3@fpt.com.vn\",\r\n      \"inv_buyerBankAccount\": \"\",\r\n      \"inv_buyerBankName\": \"\",\r\n      \"inv_paymentMethodName\": \"TM / CK\",\r\n      \"inv_sellerBankAccount\": \"1309 4009\",\r\n      \"inv_sellerBankName\": \"NH TM CP Á Châu - CN Saigon\",\r\n      \"details\": [\r\n        {\r\n          \"tab_id\": \"TAB00188\",\r\n          \"tab_table\": \"inv_InvoiceAuthDetail\",\r\n          \"data\": [\r\n            {\r\n              \"stt_rec0\": \"\",\r\n              \"inv_itemCode\": \"\",\r\n              \"inv_itemName\": \"Hợp đồng số: FISENT20-1454S2, ENT20-1410S2/HĐMB/QDTEK/1007\",\r\n              \"inv_unitCode\": \"\",\r\n              \"inv_unitName\": null,\r\n              \"inv_unitPrice\": 0.0,\r\n              \"inv_quantity\": 0.0,\r\n              \"inv_TotalAmountWithoutVat\": 0.0,\r\n              \"inv_vatAmount\": 0.0,\r\n              \"inv_TotalAmount\": 0.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"1\",\r\n              \"inv_itemCode\": \"8452\",\r\n              \"inv_itemName\": \"Hệ thống máy lạnh chính xác 31.1kW bao gồm:\",\r\n              \"inv_unitCode\": \"DVT0000005\",\r\n              \"inv_unitName\": \"Bộ\",\r\n              \"inv_unitPrice\": 381157713.0,\r\n              \"inv_quantity\": 1.0,\r\n              \"inv_TotalAmountWithoutVat\": 381157713.0,\r\n              \"inv_vatAmount\": 38115771.0,\r\n              \"inv_TotalAmount\": 419273484.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"\",\r\n              \"inv_itemCode\": \"P1030\",\r\n              \"inv_itemName\": \"Bộ máy lạnh chính xác Liebert PEX3\",\r\n              \"inv_unitCode\": \"DVT0000004\",\r\n              \"inv_unitName\": \"Cái\",\r\n              \"inv_unitPrice\": 0.0,\r\n              \"inv_quantity\": 1.0,\r\n              \"inv_TotalAmountWithoutVat\": 0.0,\r\n              \"inv_vatAmount\": 0.0,\r\n              \"inv_TotalAmount\": 0.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"\",\r\n              \"inv_itemCode\": \"LSF42-R3\",\r\n              \"inv_itemName\": \"Dàn nóng đặt ngoài trời\",\r\n              \"inv_unitCode\": \"DVT0000004\",\r\n              \"inv_unitName\": \"Cái\",\r\n              \"inv_unitPrice\": 0.0,\r\n              \"inv_quantity\": 1.0,\r\n              \"inv_TotalAmountWithoutVat\": 0.0,\r\n              \"inv_vatAmount\": 0.0,\r\n              \"inv_TotalAmount\": 0.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"\",\r\n              \"inv_itemCode\": \"8388\",\r\n              \"inv_itemName\": \"Chi phí kiểm tra, vận hành hệ thống và đào tạo vận hành cho hệ thống làm mát\",\r\n              \"inv_unitCode\": \"DVT0000045\",\r\n              \"inv_unitName\": \"Lượt\",\r\n              \"inv_unitPrice\": 0.0,\r\n              \"inv_quantity\": 1.0,\r\n              \"inv_TotalAmountWithoutVat\": 0.0,\r\n              \"inv_vatAmount\": 0.0,\r\n              \"inv_TotalAmount\": 0.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"2\",\r\n              \"inv_itemCode\": \"7913\",\r\n              \"inv_itemName\": \"Bộ lưu điện Liebert EXS UPS 60kVA, thời gian lưu 15 phút, tải 49kW gồm:\",\r\n              \"inv_unitCode\": \"DVT0000005\",\r\n              \"inv_unitName\": \"Bộ\",\r\n              \"inv_unitPrice\": 369163890.0,\r\n              \"inv_quantity\": 2.0,\r\n              \"inv_TotalAmountWithoutVat\": 738327780.0,\r\n              \"inv_vatAmount\": 73832778.0,\r\n              \"inv_TotalAmount\": 812160558.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"\",\r\n              \"inv_itemCode\": \"Liebert EXS\",\r\n              \"inv_itemName\": \"Bộ lưu điện Liebert EXS 60kVA 400V Tiêu Chuẩn bao gồm:- Cáp kết nối parallel.- Cảm biến nhiệt độ trong acquy.- Cạc giám sát IS-UNITY-DP\",\r\n              \"inv_unitCode\": \"DVT0000004\",\r\n              \"inv_unitName\": \"Cái\",\r\n              \"inv_unitPrice\": 0.0,\r\n              \"inv_quantity\": 2.0,\r\n              \"inv_TotalAmountWithoutVat\": 0.0,\r\n              \"inv_vatAmount\": 0.0,\r\n              \"inv_TotalAmount\": 0.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"\",\r\n              \"inv_itemCode\": \"7896\",\r\n              \"inv_itemName\": \"Chuỗi ắcquy hỗ trợ lưu điện 15 phút với tải 49kW cho mỗi bộ lưu điện, 40 ắcquy/bộ\",\r\n              \"inv_unitCode\": \"DVT0000005\",\r\n              \"inv_unitName\": \"Bộ\",\r\n              \"inv_unitPrice\": 0.0,\r\n              \"inv_quantity\": 2.0,\r\n              \"inv_TotalAmountWithoutVat\": 0.0,\r\n              \"inv_vatAmount\": 0.0,\r\n              \"inv_TotalAmount\": 0.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"\",\r\n              \"inv_itemCode\": \"339\",\r\n              \"inv_itemName\": \"Tủ chứa Ắcquy và phụ kiện kết nối Ắcquy\",\r\n              \"inv_unitCode\": \"DVT0000004\",\r\n              \"inv_unitName\": \"Cái\",\r\n              \"inv_unitPrice\": 0.0,\r\n              \"inv_quantity\": 2.0,\r\n              \"inv_TotalAmountWithoutVat\": 0.0,\r\n              \"inv_vatAmount\": 0.0,\r\n              \"inv_TotalAmount\": 0.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"\",\r\n              \"inv_itemCode\": \"8387\",\r\n              \"inv_itemName\": \"Chi phí kiểm tra, vận hành hệ thống và đào tạo vận hành cho hệ thống lưu điện\",\r\n              \"inv_unitCode\": \"DVT0000045\",\r\n              \"inv_unitName\": \"Lượt\",\r\n              \"inv_unitPrice\": 0.0,\r\n              \"inv_quantity\": 2.0,\r\n              \"inv_TotalAmountWithoutVat\": 0.0,\r\n              \"inv_vatAmount\": 0.0,\r\n              \"inv_TotalAmount\": 0.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"3\",\r\n              \"inv_itemCode\": \"\",\r\n              \"inv_itemName\": \"THANH PHÂN PHỐI NGUỒN GẮN RACK 32A GỒM:\",\r\n              \"inv_unitCode\": \"\",\r\n              \"inv_unitName\": null,\r\n              \"inv_unitPrice\": 0.0,\r\n              \"inv_quantity\": 0.0,\r\n              \"inv_TotalAmountWithoutVat\": 0.0,\r\n              \"inv_vatAmount\": 0.0,\r\n              \"inv_TotalAmount\": 0.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"\",\r\n              \"inv_itemCode\": \"8378\",\r\n              \"inv_itemName\": \"Thanh phân phối nguồn: 20 ổ cắm C13 + 4 ổ cắm C19, 32A IEC309, Màu đen\",\r\n              \"inv_unitCode\": \"DVT0000004\",\r\n              \"inv_unitName\": \"Cái\",\r\n              \"inv_unitPrice\": 5293925.0,\r\n              \"inv_quantity\": 12.0,\r\n              \"inv_TotalAmountWithoutVat\": 63527100.0,\r\n              \"inv_vatAmount\": 6352710.0,\r\n              \"inv_TotalAmount\": 69879810.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"4\",\r\n              \"inv_itemCode\": \"8454\",\r\n              \"inv_itemName\": \"Hệ Thống Giám Sát RDU mở rộng gồm:\",\r\n              \"inv_unitCode\": \"DVT0000005\",\r\n              \"inv_unitName\": \"Bộ\",\r\n              \"inv_unitPrice\": 44128297.0,\r\n              \"inv_quantity\": 1.0,\r\n              \"inv_TotalAmountWithoutVat\": 44128297.0,\r\n              \"inv_vatAmount\": 4412830.0,\r\n              \"inv_TotalAmount\": 48541127.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"\",\r\n              \"inv_itemCode\": \"IRM-8DIAI\",\r\n              \"inv_itemName\": \"Cạc mở rộng 8 đầu vào kỹ thuật số\",\r\n              \"inv_unitCode\": \"DVT0000004\",\r\n              \"inv_unitName\": \"Cái\",\r\n              \"inv_unitPrice\": 0.0,\r\n              \"inv_quantity\": 1.0,\r\n              \"inv_TotalAmountWithoutVat\": 0.0,\r\n              \"inv_vatAmount\": 0.0,\r\n              \"inv_TotalAmount\": 0.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"\",\r\n              \"inv_itemCode\": \"IRMS02TH\",\r\n              \"inv_itemName\": \"Cảm biến nhiệt độ và độ ẩm\",\r\n              \"inv_unitCode\": \"DVT0000004\",\r\n              \"inv_unitName\": \"Cái\",\r\n              \"inv_unitPrice\": 0.0,\r\n              \"inv_quantity\": 4.0,\r\n              \"inv_TotalAmountWithoutVat\": 0.0,\r\n              \"inv_vatAmount\": 0.0,\r\n              \"inv_TotalAmount\": 0.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"\",\r\n              \"inv_itemCode\": \"IRM-S01W(10m)\",\r\n              \"inv_itemName\": \"Cảm biến nước (10m)\",\r\n              \"inv_unitCode\": \"DVT0000004\",\r\n              \"inv_unitName\": \"Cái\",\r\n              \"inv_unitPrice\": 0.0,\r\n              \"inv_quantity\": 1.0,\r\n              \"inv_TotalAmountWithoutVat\": 0.0,\r\n              \"inv_vatAmount\": 0.0,\r\n              \"inv_TotalAmount\": 0.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            },\r\n            {\r\n              \"stt_rec0\": \"\",\r\n              \"inv_itemCode\": \"8389\",\r\n              \"inv_itemName\": \"Chi phí kiểm tra, vận hành hệ thống và đào tạo vận hành cho hệ thống giám sát\",\r\n              \"inv_unitCode\": \"DVT0000045\",\r\n              \"inv_unitName\": \"Lượt\",\r\n              \"inv_unitPrice\": 0.0,\r\n              \"inv_quantity\": 1.0,\r\n              \"inv_TotalAmountWithoutVat\": 0.0,\r\n              \"inv_vatAmount\": 0.0,\r\n              \"inv_TotalAmount\": 0.0,\r\n              \"inv_promotion\": false,\r\n              \"inv_discountPercentage\": 0.0,\r\n              \"inv_discountAmount\": 0.0,\r\n              \"ma_thue\": 10.0\r\n            }\r\n          ]\r\n        }\r\n      ]\r\n    }\r\n  ],\r\n  \"editmode\": \"2\"\r\n}";

            string ketqua = client2.UploadString("http://0303754648.minvoice.com.vn/api/InvoiceAPI/Save", invoice);

            return View();
        }
    }
}
