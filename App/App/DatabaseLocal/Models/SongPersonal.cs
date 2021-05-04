using App.Common;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace App.DatabaseLocal.Models
{
    public class SongPersonal
    {
        public int ID { get; set; }

        public SongPersonal()
        {
        }

        public SongPersonal(int id)
        {
            this.ID = id;
        }

        public SongPersonal(List<object> objValues)
        {
            try
            {
                var m = 0;
                foreach (PropertyInfo p in typeof(SongPersonal).GetProperties())
                {
                    string propertyName = p.Name;
                    var propertyType = p.PropertyType.Name;
                    var type = p.PropertyType;

                    var value = Converters<SongPersonal>.StringToValue(objValues[m++].ToString(), type);
                    var msgInfo = this.GetType().GetProperty(propertyName);

                    msgInfo.SetValue(this, value, null);
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}