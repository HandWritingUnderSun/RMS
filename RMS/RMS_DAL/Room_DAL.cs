using System.Collections.Generic;
using RMS.Model;
using System.Data.SqlClient;

/***********************************************************************************************
 * 2017年06月20日
 * 数据层：处理房间相关信息
 * */

namespace RMS.DAL
{
    public class Room_DAL
    {
        /// <summary>
        /// 获取房间
        /// </summary>
        /// <returns></returns>
        public List<Room> SelectRoom()
        {
            string sqlStr = "select RoomID,RoomName from tb_Room";
            List<Room> rtnList = new List<Room>();
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sqlStr);
            while (reader.Read())
            {
                rtnList.Add(new Room(reader.GetInt32(0), reader.GetString(1)));
            }
            reader.Close();
            return rtnList;
        }

        /// <summary>
        /// 添加房间
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int AddRoom(string roomName)
        {
            string sqlStr = "insert into tb_Room(RoomName) values ('" + roomName + "')";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }

        /// <summary>
        /// 删除房间
        /// </summary>
        /// <param name="matUnitID"></param>
        /// <returns></returns>
        public int DeleteRoom(int roomID)
        {
            string sqlStr = "delete from tb_Room where RoomID='" + roomID + "'";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }


        /// <summary>
        /// 修改房间
        /// </summary>
        /// <param name="matUnit"></param>
        /// <returns></returns>
        public int UpdateRoom(Room room)
        {
            string sqlStr = "update tb_Room set RoomName='" + room.RoomName + "' where RoomID='" + room.RoomID + "'";
            return DBhelp.Create().ExecuteNonQuery(sqlStr);
        }

        /// <summary>
        /// 查询是否存在该房间
        /// </summary>
        /// <param name="matTypeName"></param>
        /// <returns></returns>
        public int CountRoom(string roomName)
        {
            string sqlStr = "select count(*)  from tb_Room where RoomName='" + roomName + "'";
            return DBhelp.Create().ExecuteScalar(sqlStr);
        }
    }
}
