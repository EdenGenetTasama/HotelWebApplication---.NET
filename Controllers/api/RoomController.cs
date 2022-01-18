using HotelWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelWebApplication.Controllers.api
{
    public class RoomController : ApiController
    {
        RoomDataContext dataContext = new RoomDataContext();
        // GET: api/Room
        public IHttpActionResult Get()
        {
            try
            {
                List<Room> roomList = dataContext.Rooms.ToList();
                return Ok(roomList);
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Room/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Room roomById = dataContext.Rooms.First(item => item.Id ==id);
                if (roomById != null)
                {

                    return Ok(roomById);
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Room
        public IHttpActionResult Post([FromBody] Room room)
        {
            try
            {
                if (room != null)
                {
                    dataContext.Rooms.InsertOnSubmit(room);
                    dataContext.SubmitChanges();
                    return Ok("Added");
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Room/5
        public IHttpActionResult Put(int id, [FromBody] Room room)
        {
            try
            {
                Room roomUpdate = dataContext.Rooms.First(item => item.Id == id);
                if (roomUpdate != null)
                {
                    roomUpdate.roomNun = room.roomNun;
                    roomUpdate.kindOfRoom = room.kindOfRoom;
                    roomUpdate.isAvelible = room.isAvelible;
                    roomUpdate.price = room.price;
                    dataContext.SubmitChanges();
                    return Ok("update");
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Room/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Room roomToDelete = dataContext.Rooms.First(room => room.Id == id);
                if (roomToDelete != null)
                {
                    dataContext.Rooms.DeleteOnSubmit(roomToDelete);
                    dataContext.SubmitChanges();
                    return Ok("DELETE");
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
