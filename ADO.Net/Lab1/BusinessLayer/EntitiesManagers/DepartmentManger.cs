// Ignore Spelling: Tto

using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class ClsDepartmentManger
    {
        public static ClsDepartmentList GetAll()
        {
            DataTable dt = ClsDBManager.GetQueryResult("select * from Department");
            return MapDTtoDeptList(dt);
        }

        public static ClsDepartment GetById(int id)
        {
            DataTable dt = ClsDBManager.GetQueryResult($"select top 1 * from Department where dept_id = {id}");
            return MapDataRowToDept(dt.Rows[0]);
        }

        public static ClsDepartmentList MapDTtoDeptList(DataTable dt)
        {
            ClsDepartmentList list = [];
            foreach (DataRow dept in dt.Rows)
            {
                list.Add(MapDataRowToDept(dept));
            }
            return list;
        }

        public static ClsDepartment MapDataRowToDept(DataRow dr)
        {
            return new ClsDepartment()
            {
                Id = dr.IsNull(0) ? 0 : (int)dr[0],
                Name = dr[1]?.ToString() ?? string.Empty,
                Desc = dr[2]?.ToString() ?? string.Empty,
                Location = dr[3]?.ToString() ?? string.Empty,
                Dept_Manager = dr.IsNull(4) ? (int?)null : (int)dr[4],
                Manager_hireDate = dr.IsNull(5) ? null : DateOnly.FromDateTime((DateTime)dr[5]),
            };
        }

        public static bool InsertDept(int id, string name = null, string desc = null, string location = null, int? managerId = null, DateOnly? mngrHireDate = null)
        {
            try
            {
                ClsDBManager.ExecuteNonQuery($"insert into department ( [Dept_Id] , [Dept_Name] , [Dept_Desc] , [Dept_Location] , [Dept_Manager] ,[Manager_hiredate] ) " +
                     $"VALUES({id} " +
                     $",{(name is null ? "NULL" : $"'{name}'")} " +
                     $",{(desc is null ? "NULL" : $"'{desc}'")}" +
                     $",{(location is null ? "NULL" : $"'{location}'")}" +
                     $",{(managerId is null ? "NULL" : $"{managerId}")}" +
                     $",{(mngrHireDate is null ? "NULL" : $"'{mngrHireDate}'")})");
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool UpdateDept(int id, string name = null, string desc = null, string location = null, int? managerId = null, DateOnly? MngrHireDate = null)
        {
            try
            {
                ClsDBManager.ExecuteNonQuery($"update department " +
                    $"set dept_name = {(name is null ? "dept_name" : $"'{name}'")}," +
                    $"[Dept_Desc] =  {(desc is null ? "[Dept_Desc]" : $"'{desc}'")}," +
                    $"[Dept_Location] = {(location is null ? "[Dept_Location]" : $"'{location}'")}," +
                    $"[Dept_Manager] = {(managerId is null ? "[Dept_Manager]" : $"{managerId}")}, " +
                    $"[Manager_hiredate] = {(MngrHireDate is null ? "[Manager_hiredate]" : $"'{MngrHireDate}'")}" +
                    $"where dept_id = {id}");
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool DeleteDept(int id)
        {
            try
            {
                ClsDBManager.ExecuteNonQuery($"delete department " +
                 $"where dept_id = {id}");
                return true;
            }
            catch
            {
                return false;
            }

        }

    }
}
