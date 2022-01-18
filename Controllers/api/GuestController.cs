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
    public class GuestController : ApiController
    {

        GuestContext DBcontext = new GuestContext();
        // GET: api/Guest
        public IHttpActionResult Get()
        {
            try
            {
                List<guest> listOfGuests = DBcontext.Guests.ToList();
                return Ok(new { listOfGuests });

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

        // GET: api/Guest/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                guest guestById = DBcontext.Guests.First(item => item.Id==id);
                if (guestById != null)
                {

                    return Ok(new { guestById });
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

        // POST: api/Guest
        public IHttpActionResult Post([FromBody] guest guest)
        {
            try
            {
                if (guest != null)
                {
                    DBcontext.Guests.Add(guest);
                    DBcontext.SaveChanges();
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

        // PUT: api/Guest/5
        public IHttpActionResult Put(int id, [FromBody] guest guestById)
        {
            try
            {
                guest guestToUpdate = DBcontext.Guests.First(item => item.Id ==id);
                if (guestToUpdate != null)
                {
                    guestToUpdate.FirstName = guestById.FirstName;
                    guestToUpdate.LastName = guestById.LastName;
                    guestToUpdate.Gender=guestById.Gender;
                    guestToUpdate.YearOfBirth = guestById.YearOfBirth;
                    guestToUpdate.CheckOut = guestById.CheckOut;
                    DBcontext.SaveChanges();
                    return Ok("Updated");
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

        // DELETE: api/Guest/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                guest guestToDelete = DBcontext.Guests.First(item => item.Id ==id);
                if (guestToDelete != null)
                {
                    DBcontext.Guests.Remove(guestToDelete);
                    DBcontext.SaveChanges();
                    return Ok("DELETED");
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
