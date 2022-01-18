using HotelWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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
        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                guest guestById = await DBcontext.Guests.FindAsync(id);
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
        public async Task<IHttpActionResult> Post([FromBody] guest guest)
        {
            try
            {
                if (guest != null)
                {
                    DBcontext.Guests.Add(guest);
                    await DBcontext.SaveChangesAsync();
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
        public async Task <IHttpActionResult> Put(int id, [FromBody] guest guestById)
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
                    await DBcontext.SaveChangesAsync();
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
        public async Task <IHttpActionResult> Delete(int id)
        {
            try
            {
                guest guestToDelete = DBcontext.Guests.First(item => item.Id ==id);
                if (guestToDelete != null)
                {
                    DBcontext.Guests.Remove(guestToDelete);
                   await DBcontext.SaveChangesAsync();
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
