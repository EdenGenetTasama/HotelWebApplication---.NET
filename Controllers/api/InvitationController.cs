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
    public class InvitationController : ApiController
    {
        public string stringConnection = "Data Source=DESKTOP-0MT6QTG;Initial Catalog=HotelDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework";
        List<Invait> listOfInvitations = new List<Invait>();

        // GET: api/Invitation
        public IHttpActionResult Get()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();
                    string query = "SELECT * FROM invitation";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listOfInvitations.Add(new Invait(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5)));
                        }
                    }
                    conn.Close();
                }

                return Ok(listOfInvitations);

            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            };
        }

        // GET: api/Invitation/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = $@"SELECT * FROM invitation WHERE Id = {id}";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Invait invitationById = new Invait(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5));
                            connection.Close();
                            return Ok(invitationById);
                        }
                    }
                    return NotFound();
                }


                //return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            };
        }

        // POST: api/Invitation
        public IHttpActionResult Post([FromBody] Invait invaitToAdd)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = $@"INSERT INTO invitation (idOfGuest , numOfEmployee , dateOfInvitation , payedMoney , moreToPay) 
                                    VALUES ({invaitToAdd.IdOfGuest},{invaitToAdd.NumOfEmployee},{invaitToAdd.DateOfEmployee},{invaitToAdd.PayedMoneny},{invaitToAdd.MoreToPay})";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
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
            };
        }

        // PUT: api/Invitation/5
        public IHttpActionResult Put(int id, [FromBody] Invait invaitToUpdate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = $@"UPDATE invitation
                                    SET idOfGuest = {invaitToUpdate.IdOfGuest}, numOfEmployee = {invaitToUpdate.NumOfEmployee}, dateOfInvitation = { invaitToUpdate.DateOfEmployee }, payedMoney = { invaitToUpdate.PayedMoneny } , moreToPay= { invaitToUpdate.MoreToPay}
                                    WHERE Id = { id }";
                    SqlCommand commend = new SqlCommand(query, connection);
                    int rowEffected = commend.ExecuteNonQuery();
                    connection.Close();
                    return Ok("UPDATED");

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
            };
        }

        // DELETE: api/Invitation/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    connection.Open();
                    string query = $@"DELETE FROM invitation WHERE Id={id}";
                    SqlCommand commend = new SqlCommand(query, connection);
                    int rowEffectedDelete = commend.ExecuteNonQuery();

                    connection.Close();
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
            };
        }
    }
}
