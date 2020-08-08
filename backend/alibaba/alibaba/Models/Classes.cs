using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace alibaba.Models
{
  public class User
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    [JsonIgnore]
    public string Password { get; set; }
    public bool HotelManager { get; set; }
    public virtual ICollection<Hotel> Hotel { get; set; }

  }
  public class login
  {
    public string username { get; set; }

    public string password { get; set; }

  }
  public class Search
  {
    public string City { get; set; }
    public int Kid { get; set; }
    public int Adult { get; set; }
    public string Date { get; set; }
  }
  public class Hotel
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Address { get; set; }
    public string Location { get; set; }
    public long HotelManagerId { get; set; }

    [ForeignKey("HotelManagerId")]
    public virtual User HotelManager { get; set; }

    public virtual ICollection<Feature> Feature { get; set; }
    public virtual ICollection<Room> Room { get; set; }
    public virtual ICollection<Pic> Pic { get; set; }

  }
  public class Feature
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
    public long HotelId { get; set; }
    [ForeignKey("HotelId")]
    public virtual Hotel Hotel { get; set; }
  }
  public class Room
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public string Name { get; set; }
    public int Adult { get; set; }
    public int Kid { get; set; }
    public bool Breakfast { get; set; }
    public long HotelId { get; set; }
    [ForeignKey("HotelId")]
    public virtual Hotel Hotel { get; set; }
  }
  public class Pic
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
    public long HotelId { get; set; }
    [ForeignKey("HotelId")]
    public virtual Hotel Hotel { get; set; }
  }
  public class Reserve
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public string Date { get; set; }
    public int Adult { get; set; }
    public int Kid { get; set; }
    public string Description { get; set; }

    public long UserId { get; set; }
    [ForeignKey("UserId")]
    public virtual User User { get; set; }

    public long RoomId { get; set; }
    [ForeignKey("RoomId")]
    public virtual Room Room { get; set; }

    public long HotelId { get; set; }
    [ForeignKey("HotelId")]
    public virtual Hotel Hotel { get; set; }
  }
}
