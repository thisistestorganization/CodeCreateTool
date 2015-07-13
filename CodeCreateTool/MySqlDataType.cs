using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCreateTool
{
    public enum MySqlDataType 
    {
        DECIMAL = 0,
        BYTE = 1,
        INT16 = 2,
        INT32 = 3,
        FLOAT = 4,
        DOUBLE = 5,
        TIMESTAMP = 7,
        INT64 = 8,
        INT24 = 9,
        DATE = 10,
        TIME = 11,
        DATETIME = 12,
        [Obsolete("The Datetime enum value is obsolete.  Please use DateTime.")]
        //DATETIME = 12,
        YEAR = 13,
        NEWDATE = 14,
        VARSTRING = 15,
        BIT = 16,
        MEDIUMINT = 100,
        TINYINT=101,
        SMALLINT=102,
        INT=103,
        CHAR = 104,
        NEWDECIMAL = 246,
        EEUM = 247,
        SET = 248,
        TINYBLOB = 249,
        MEDIUMBLOB = 250,
        LONGBLOB = 251,
        BLOB = 252,
        VARCHAR = 253,
        STRING = 254,
        GEOMETRY = 255,
        UBYTE = 501,
        UINT16 = 502,
        UINT32 = 503,
        UINT64 = 508,
        UINT24 = 509,
        BINARY = 600,
        VarBINARY = 601,
        TINYTEXT = 749,
        MEDIUMTEXT = 750,
        LONGTEXT = 751,
        TEXT = 752,
        GUID = 800,
    }
}
