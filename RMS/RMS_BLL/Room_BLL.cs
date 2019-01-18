using System.Collections.Generic;
using RMS.DAL;
using RMS.Model;

/***********************************************************************************************
 * 2017年06月20日
 * 业务逻辑层：处理房间相关信息
 * */

namespace RMS.BLL
{
    public class Room_BLL
    {
        Room_DAL room_DAL = new Room_DAL();
 
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Room> SelectRoom()
        {
            return room_DAL.SelectRoom();
        }

        /// <summary>
        /// 查询房间是否已经存在
        /// </summary>
        /// <returns></returns>
        public bool IsRoomHaving(string roomName)
        {
            if (room_DAL.CountRoom(roomName) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 添加房间
        /// </summary>
        /// <param name="roomName"></param>
        /// <returns></returns>
        public bool AddRoom(string roomName)
        {
            if (room_DAL.AddRoom(roomName) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 删除资料类型
        /// </summary>
        /// <param name="roomID"></param>
        /// <returns></returns>
        public bool deleteRoom(int roomID)
        {
            if (room_DAL.DeleteRoom(roomID) > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 修改资料类型
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public bool IsUpdateRoom(Room room)
        {
            if (room_DAL.UpdateRoom(room) > 0)
                return true;
            else
                return false;
        }
    }
}
