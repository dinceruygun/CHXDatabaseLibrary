using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;
using Newtonsoft.Json;

namespace CHXDataModel
{
    public class CHXModelCollection : IEnumerable
    {
        List<CHXModel> _modelList;

        private List<CHXModel> ModelList
        {
            get
            {
                return _modelList;
            }
        }


        public CHXModelCollection()
        {
            _modelList = new List<CHXModel>();

            GetModels();
        }


        public CHXModel this[int index]
        {
            get
            {
                return this._modelList[index];
            }
        }

        public void Remove(string name)
        {
            var model = this.Find(name);

            if (model == null) throw new Exception("Silinecek model bulunamadı");

            this._modelList.Remove(model);

            this.SetModels();
        }

        public CHXModel this[string name]
        {
            get
            {
                return Find(name);
            }
        }

        public CHXModel Find(string name)
        {
            return this._modelList.Find(m => m.Name == name);
        }

        
        public void Add(CHXModel model)
        {
            if (model == null) throw new ArgumentNullException("model objesi null olamaz");
            if (string.IsNullOrEmpty(model.Name)) throw new ArgumentNullException("Model adı boş olamaz");
            if (this.Find(model.Name) != null) throw new Exception("Aynı adı kullanan farklı model bulunuyor");
            if (model.Name.HasSpecialChars()) throw new Exception("Model adı, boşluk karakteri de dahil özel karakter içeremez");

            ModelList.Add(model);

            SetModels();
        }


        


        private void SetModels()
        {
            var data = JsonConvert.SerializeObject(ModelList);

            CHXSettings.CHXSettingsManager.Set("chxmodellist", data);
        }


        private void GetModels()
        {
            string data = CHXSettings.CHXSettingsManager.Get("chxmodellist");

            if (string.IsNullOrEmpty(data)) return;

            this._modelList = JsonConvert.DeserializeObject<List<CHXModel>>(data);
        }


        public IEnumerator GetEnumerator()
        {
            return ModelList.GetEnumerator();
        }
    }
}
