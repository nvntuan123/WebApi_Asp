using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_Levinci.Models
{
    [Table("User")]
    public class Users
    {
        private string? _strID;

        [Key, Column("ID", Order = 0, TypeName = "varchar")]
        [MaxLength(10)]
        public string? strID
        {
            get { return _strID; }
            set { _strID = value; }
        }

        private string? _strUserName;

        [Column("UserName", Order = 1, TypeName = "varchar")]
        [MaxLength(100)]
        public string? strUserName
        {
            get { return _strUserName; }
            set { _strUserName = value; }
        }

        private string? _strName;

        [Column("Name", Order = 3, TypeName = "varchar")]
        [MaxLength(100)]
        public string? strName
        {
            get { return _strName; }
            set { _strName = value; }
        }

        private string? _strRole;

        [Column("Role", Order = 4, TypeName = "varchar")]
        [MaxLength(100)]
        public string? strRole
        {
            get { return _strRole; }
            set { _strRole = value; }
        }

        private string? _strEmail;

        [Column("Email", Order = 5, TypeName = "varchar")]
        [MaxLength(100)]
        public string? strEmail
        {
            get { return _strEmail; }
            set { _strEmail = value; }
        }

        private byte[]? _bPasswordHash;

        [Column("PasswordHash", Order = 6, TypeName = "varbinary(max)")]
        public byte[]? bPasswordHash
        {
            get { return _bPasswordHash; }
            set { _bPasswordHash = value; }
        }

        private byte[]? _bPasswordSalt;

        [Column("PasswordSalt", Order = 7, TypeName = "varbinary(max)")]
        public byte[]? bPasswordSalt
        {
            get { return _bPasswordSalt; }
            set { _bPasswordSalt = value; }
        }
    }
}
