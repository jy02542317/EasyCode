﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Data;

namespace EasyCodeM2G
{
    public static class Util
    {
        public static String UpperCase(String str)
        {
            char[] ch = str.ToCharArray();
            if (ch[0] >= 'a' && ch[0] <= 'z')
            {
                ch[0] = (char)(ch[0] - 32);
            }
            return new String(ch);
        }

        public static string ConvertDataType(string name)
        {
            string result = string.Empty;
            switch (name)
            {
                case "Int32":
                    result = "int";
                    break;
                case "Int16":
                    result = "short";
                    break;
                case "Int64":
                    result = "long";
                    break;
                case "String":
                    result = "string";
                    break;
                case "Boolean":
                    result = "bool";
                    break;
                case "Byte[]":
                    result = "byte[]";
                    break;
                case "Double":
                    result = "double";
                    break;
                case "Decimal":
                    result = "decimal";
                    break;
                case "Char":
                    result = "char";
                    break;
                case "Single":
                    result = "float";
                    break;
                case "Byte":
                    result = "byte";
                    break;
                case "Object":
                    result = "object";
                    break;
                case "Guid":
                    result = "Guid";
                    break;
                default:
                    result = name;
                    break;
            }
            return result;
        }

        public static string ConvertM2gDataType(string name)
        {
            string result = string.Empty;
            switch (name)
            {
                case "Int32":
                    result = "IntField";
                    break;
                case "Int16":
                    result = "IntField";
                    break;
                case "Int64":
                    result = "IntField";
                    break;
                case "String":
                    result = "StringField";
                    break;
                case "Boolean":
                    result = "BoolField";
                    break;
                case "Byte[]":
                    result = "byte[]";
                    break;
                case "Double":
                    result = "DoubleField";
                    break;
                case "Decimal":
                    result = "DecimalField";
                    break;
                case "Char":
                    result = "char";
                    break;
                case "Single":
                    result = "FloatField";
                    break;
                case "Byte":
                    result = "byte";
                    break;
                case "Object":
                    result = "object";
                    break;
                case "Guid":
                    result = "Guid";
                    break;
                case "DateTime":
                    result = "DateField";
                    break;
                default:
                    result = name;
                    break;
            }
            return result;
        }


        public static void showDialog(out string filename){
            
            OpenFileDialog op = new OpenFileDialog();
            //  op.InitialDirectory = lblSavePath.Content.ToString();//默认的打开路径
            op.RestoreDirectory = true;
            op.Filter = "Excel文件|*.csv;*.xlsx;*.xls|All files(*.*)|*.* ";
            op.ShowDialog();
            filename = op.FileName;
            
        }


        public static void RemoveEmpty(DataTable dt)
        {
            List<DataRow> removelist = new List<DataRow>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool IsNull = true;
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (!string.IsNullOrEmpty(dt.Rows[i][j].ToString().Trim()))
                    {
                        IsNull = false;
                    }
                }
                if (IsNull)
                {
                    removelist.Add(dt.Rows[i]);
                }
            }
            for (int i = 0; i < removelist.Count; i++)
            {
                dt.Rows.Remove(removelist[i]);
            }
        }
    }
}

