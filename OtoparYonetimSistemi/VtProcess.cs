using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Drawing;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Reflection;

namespace OtoparYonetimSistemi
{
    internal class VtProcess
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "bLalvnaXmd0wNL4N8t5jOCdTAe08djCI576BZLN3",
            BasePath = "https://otoparkyonetimsistemi-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient ifc;
        public void FirebaseConnect()
        {
            ifc = new FireSharp.FirebaseClient(config);
        }
        public async void AddData(string plate, string brad, string model, string color, string time, int repice, string statu)
        {
            FirebaseConnect();
            SetResponse response;
            CarProperty result;

            var car = new CarProperty()
            {
                numberPlate = plate,
                brand = brad,
                model = model,
                color = color,
                time = time,
                repice = repice,
                statu = statu,
            };

            response = await ifc.SetAsync("entrance/" + car.numberPlate + "/", car);
            result = response.ResultAs<CarProperty>();
        }
        public async void GetEntranceData(DataGridView dgv)
        {
            FirebaseConnect();
            try
            {
                dgv.Rows.Clear();
                if (ifc != null)
                {
                    FirebaseResponse response = await ifc.GetAsync("entrance");


                    if (response != null)
                    {
                        if (response.Body.StartsWith("[") && response.Body.EndsWith("]"))
                        {
                            List<CarProperty> dataArray = response.ResultAs<List<CarProperty>>();
                            foreach (var entry in dataArray)
                            {
                                if (entry != null)
                                {
                                    dgv.Rows.Add(null, null, entry.numberPlate, entry.time, entry.brand, entry.model, entry.color);
                                }

                            }
                        }
                        else
                        {
                            Dictionary<string, CarProperty> data = response.ResultAs<Dictionary<string, CarProperty>>();

                            if (data != null)
                            {
                                foreach (var entry in data)
                                {
                                    if (entry.Value != null)
                                    {
                                        dgv.Rows.Add(null, null, entry.Value.numberPlate, entry.Value.time, entry.Value.brand, entry.Value.model, entry.Value.color);
                                    }
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        public async Task Search(DataGridView dgv, String numberPlate, String brand, String model, String color)
        {
            FirebaseConnect();
            try
            {
                dgv.Rows.Clear();

                if (ifc != null)
                {
                    FirebaseResponse response = await ifc.GetAsync("entrance");

                    if (response != null)
                    {
                        if (response.Body.StartsWith("[") && response.Body.EndsWith("]"))
                        {
                            List<CarProperty> dataArray = response.ResultAs<List<CarProperty>>();

                            foreach (var entry in dataArray)
                            {
                                if (entry != null)
                                {
                                    if (entry.numberPlate == numberPlate)
                                    {
                                        dgv.Rows.Add(null, null, entry.numberPlate, entry.time, entry.brand, entry.model, entry.color);
                                    }

                                    if (entry.brand == brand)
                                    {
                                        dgv.Rows.Add(null, null, entry.numberPlate, entry.time, entry.brand, entry.model, entry.color);
                                    }
                                    if (entry.model == model)
                                    {
                                        dgv.Rows.Add(null, null, entry.numberPlate, entry.time, entry.brand, entry.model, entry.color);
                                    }
                                    if (entry.color == color)
                                    {
                                        dgv.Rows.Add(null, null, entry.numberPlate, entry.time, entry.brand, entry.model, entry.color);
                                    }
                                }
                            }
                        }
                        else
                        {
                            Dictionary<string, CarProperty> data = response.ResultAs<Dictionary<string, CarProperty>>();
                            if (data != null)
                            {
                                foreach (var entry in data)
                                {
                                    if (entry.Value != null)
                                    {
                                        if (entry.Value.numberPlate == numberPlate)
                                        {
                                            dgv.Rows.Add(null, null, entry.Value.numberPlate, entry.Value.time, entry.Value.brand, entry.Value.model, entry.Value.color);
                                        }

                                        if (entry.Value.brand == brand)
                                        {
                                            dgv.Rows.Add(null, null, entry.Value.numberPlate, entry.Value.time, entry.Value.brand, entry.Value.model, entry.Value.color);

                                        }
                                        if (entry.Value.model == model)
                                        {
                                            dgv.Rows.Add(null, null, entry.Value.numberPlate, entry.Value.time, entry.Value.brand, entry.Value.model, entry.Value.color);

                                        }
                                        if (entry.Value.color == color)
                                        {
                                            dgv.Rows.Add(null, null, entry.Value.numberPlate, entry.Value.time, entry.Value.brand, entry.Value.model, entry.Value.color);
                                        }
                                    }

                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Search: " + ex.Message);
            }

        }
        public async Task DeleteChildAsync()
        {
            FirebaseConnect();

            DialogResult result = MessageBox.Show("Tüm Kayıtlar Silinecektir.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (DialogResult.Yes == result)
            {
                var deleteResponse = await ifc.DeleteAsync("entrance");
            }

            FirebaseConnect();

        }
        public async void RemoveRecord(string plate)
        {
            FirebaseConnect();
            ifc.DeleteAsync("entrance/" + plate);
        }
        public async Task<int> GetParkingCapacity()
        {
            FirebaseConnect();
            try
            {
                if (ifc != null)
                {
                    FirebaseResponse response = await ifc.GetAsync("parkingCapacity/capacity");

                    if (response != null)
                    {
                        int capacityValue = response.ResultAs<int>();
                        return capacityValue;
                    }
                    else
                    {
                        MessageBox.Show("Firebase Hatası: " + response?.Body);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Get: " + ex.Message);
            }
            return -1;
        }
        public async void ChangeParkingCapacity(string newCapacity)
        {
            FirebaseConnect();
            try
            {
                if (ifc != null)
                {
                    SetResponse response = await ifc.SetAsync("parkingCapacity/capacity", newCapacity);

                    if (response != null)
                    {
                        DialogResult result = MessageBox.Show("başarıyla güncellendi.\n Uygulama yeniden başlatılacak.");

                        if (DialogResult.OK == result)
                        {
                            Application.Restart();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Set: " + ex.Message);
            }
        }
        public async Task RepiceUpdate(int _hourly, int _monthly, int _weekly)
        {
            SetResponse response;
            RepiceProperty result;

            var repice = new RepiceProperty()
            {
                hourly = _hourly,
                weekly = _weekly,
                monthly = _monthly,
            };

            response = await ifc.SetAsync("recipe/", repice);
            result = response.ResultAs<RepiceProperty>();
            if (result != null)
            {
                DialogResult re = MessageBox.Show("Güncelleme Başarılı.\n Uygulama Yeniden Başlatılacak.");
                if (DialogResult.OK == re)
                {
                    Application.Restart();
                }
            }
        }
        public bool IsInternetAvailable()
        {
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("www.google.com", 1000);
                return (reply != null && reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<int> GetEntranceCount()
        {
            FirebaseConnect();
            int childCount = 0;

            if (ifc != null)
            {
                FirebaseResponse response = await ifc.GetAsync("entrance");

                if (response != null && !string.IsNullOrEmpty(response.Body))
                {
                    if (response.Body.StartsWith("[") && response.Body.EndsWith("]"))
                    {
                        var dataArray = response.ResultAs<List<object>>();
                        childCount = dataArray?.Count ?? 0;
                    }
                    else
                    {
                        var data = response.ResultAs<Dictionary<string, object>>();
                        childCount = data?.Count ?? 0;
                    }
                }
            }

            return childCount;
        }
        public async Task DataUpdate(string _plate, string plate, string brand, string model, string color, string _time, int _repice, string statu)
        {
            FirebaseConnect();
            AddData(plate, brand, model, color, _time, _repice, statu);
            if (_plate != plate)
            {
                var deleteResponse = await ifc.DeleteAsync("entrance/" + _plate);
            }
        }
        public async Task<(int hourly, int weekly, int monthly)> GetRecipeData()
        {
            FirebaseConnect();
            try
            {
                if (ifc != null)
                {
                    FirebaseResponse responseH = await ifc.GetAsync("recipe/hourly");
                    FirebaseResponse responseM = await ifc.GetAsync("recipe/weekly");
                    FirebaseResponse responseY = await ifc.GetAsync("recipe/monthly");

                    if (responseH != null && responseM != null && responseY != null)
                    {
                        int h = responseH.ResultAs<int>();
                        int m = responseM.ResultAs<int>();
                        int y = responseY.ResultAs<int>();
                        return (h, m, y);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return (0, 0, 0);
        }
        public async Task<(string plate, string brand, string model, string color, string time, int repice, string statu)> ExtractCarProperties(string selectNumber)
        {
            FirebaseConnect();
            try
            {
                if (ifc != null)
                {
                    FirebaseResponse response = await ifc.GetAsync("entrance/");

                    if (response != null)
                    {
                        if (response.Body.StartsWith("[") && response.Body.EndsWith("]"))
                        {
                            List<CarProperty> dataArray = response.ResultAs<List<CarProperty>>();
                            foreach (var entry in dataArray)
                            {
                                if (entry != null)
                                {
                                    if (entry.numberPlate == selectNumber)
                                    {
                                        return (entry.numberPlate, entry.brand, entry.model, entry.color, entry.time, entry.repice, entry.statu);
                                    }

                                }
                            }
                        }
                        else
                        {
                            Dictionary<string, CarProperty> data = response.ResultAs<Dictionary<string, CarProperty>>();
                            if (data != null)
                            {
                                foreach (var entry in data)
                                {
                                    if (entry.Value != null)
                                    {
                                        if (entry.Value.numberPlate == selectNumber)
                                        {
                                            return (entry.Value.numberPlate, entry.Value.brand, entry.Value.model, entry.Value.color, entry.Value.time, entry.Value.repice, entry.Value.statu);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Get: " + ex.Message);
            }
            return (null, null, null, null, null, 0, null);

        }
    }
}














