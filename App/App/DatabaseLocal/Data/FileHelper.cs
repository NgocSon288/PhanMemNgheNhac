using App.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DatabaseLocal.Data
{
    public class FileHelper<T>
    {
        private string FilePath { get; set; }

        public FileHelper()
        {
            FilePath = "../../DatabaseLocal/DB/" + typeof(T).Name + ".txt";
        }

        /// <summary>
        /// Insert 1 danh sách, có thể overide hoặc không
        /// Mặc định sẽ là ghi đè lại toàn bộ file
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="isOveride"></param>
        /// <returns></returns>
        public bool InsertRange(List<T> entities, bool isOveride = true)
        {
            if (isOveride)
            {
                try
                {
                    FileStream fs = new FileStream(FilePath, FileMode.Truncate, FileAccess.Write, FileShare.None);

                    fs.Close(); 
                }
                catch (Exception)
                { 
                }
            }

            try
            {
                FileStream fs = new FileStream(FilePath, (isOveride ? FileMode.OpenOrCreate : FileMode.Append), FileAccess.Write, FileShare.None);
                StreamWriter sw = new StreamWriter(fs);

                foreach (var entity in entities)
                {
                    sw.WriteLine(Converters<T>.EntityToString(entity));
                }

                sw.Flush();
                sw.Close();
                fs.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Đọc dữ liệu từ file, chuyễn dữ liệu ra danh sách các List<Object>
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            try
            {
                FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                StreamReader sr = new StreamReader(fs);
                List<T> result = new List<T>();
                string str = "";

                while ((str = sr.ReadLine()) != null)
                {
                    result.Add((T)Activator.CreateInstance(typeof(T), Converters<T>.StringToObjectList(str)));
                }

                sr.Close();
                fs.Close();

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public T GetByID(Guid id)
        {
            try
            {
                FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                StreamReader sr = new StreamReader(fs);
                T entity = default;

                string str = "";

                while ((str = sr.ReadLine()) != null)
                {
                    if (str.Contains(id.ToString()))
                    {
                        entity = (T)Activator.CreateInstance(typeof(T), Converters<T>.StringToObjectList(str));
                    }
                }

                sr.Close();
                fs.Close();

                return entity;
            }
            catch (Exception)
            {
                return default;
            }
        }

        /// <summary>
        /// Xóa tất cả dữ liệu trong file
        /// </summary>
        /// <returns></returns>
        public bool DeleteAll()
        {
            try
            {
                FileStream fs = new FileStream(FilePath, FileMode.Truncate, FileAccess.Write, FileShare.None);

                fs.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Xóa dựa vào ID
        /// </summary>
        /// <returns></returns>
        public bool DeleteByID(Guid id)
        {
            try
            {
                var list = GetAll();
                var entity = list.FirstOrDefault(m =>
                {
                    return Converters<T>.GetIDByGeneritType(m) == id;
                });

                list.Remove(entity);
                DeleteAll();

                return InsertRange(list);
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Thêm một entity vào cuối file
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Insert(T entity)
        {
            try
            {
                FileStream fs = new FileStream(FilePath, FileMode.Append, FileAccess.Write, FileShare.None);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(Converters<T>.EntityToString(entity));

                sw.Flush();
                sw.Close();
                fs.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Cập nhật entity truyền vào
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(T entity)
        {
            try
            {
                var list = GetAll();
                var type = entity.GetType();
                var pinfo = type.GetProperties();
                var values = Converters<T>.StringToObjectList(Converters<T>.EntityToString(entity));
                var i = 0;
                var inst = list.FirstOrDefault(m => Converters<T>.GetIDByGeneritType(m) == Converters<T>.GetIDByGeneritType(entity));

                foreach (var item in pinfo)
                {
                    item.SetValue(inst, Converters<T>.StringToValue(values[i++].ToString(), item.PropertyType), null);
                }

                DeleteAll();

                return InsertRange(list);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
