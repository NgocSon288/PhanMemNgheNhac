using App.Common;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace App.DatabaseLocal.Models
{
    public class SongSeen
    {
        public int ID { get; set; }

        public SongSeen()
        {
        }

        public SongSeen(int id)
        {
            this.ID = id;
        }

        public SongSeen(List<object> objValues)
        {
            try
            {
                var m = 0;
                foreach (PropertyInfo p in typeof(SongSeen).GetProperties())
                {
                    string propertyName = p.Name;
                    var propertyType = p.PropertyType.Name;
                    var type = p.PropertyType;

                    var value = Converters<SongSeen>.StringToValue(objValues[m++].ToString(), type);
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