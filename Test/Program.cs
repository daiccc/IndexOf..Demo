using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "AaBbCcDdAaBbCcDd";
            string str2 = "CcD";

            Console.WriteLine("---------------------转换大小写-----------------------");

            // str1.ToLower()：转成小写
            Console.WriteLine($"{str1}转成小写：{str1.ToLower()}\r\n");

            // str1.ToUpper()：转成大写
            Console.WriteLine($"{str1}转成大写：{str1.ToUpper()}\r\n");


            Console.WriteLine("---------------------转换字符数组-----------------------");

            // str1.ToCharArray()：将字符串对象中的字符转换为一个字符数组
            Console.Write($"{str1}转成字符数组：");
            foreach (var item in str1.ToCharArray()) Console.Write($"{item} ");
            Console.Write("\r\n\r\n");

            Console.WriteLine("---------------------字符串长度-----------------------");

            // str1.Length：字符串长度
            Console.WriteLine($"{str1}的长度：{str1.Length}\r\n");

            Console.WriteLine("---------------------正向查找-----------------------");

            // str1.IndexOf(str2)：从前往后，查找字符串中指定字符或字符串首次出现的位置,返回索引值
            //StringComparison.OrdinalIgnoreCase：str1.IndexOf(str2,StringComparison.OrdinalIgnoreCase)，设置不区分大小写
            Console.WriteLine($"从前往后，查找【{str1}】中【{str2}】首次出现的位置索引值：{str1.IndexOf(str2)}\r\n");

            // str1.IndexOfAny(str2)：从前往后，查找字符串中字符数组中任意字符首次出现的位置,返回索引值
            char[] str3 = { 'B', 'c' };
            Console.WriteLine(str1.IndexOfAny(str3, 3));

            // str1.IndexOf(str2, startIndex)：从前往后，从第startIndex个字符开始(查找顺序：startIndex -> str1.Length)查找字符串中指定字符或字符串首次出现的位置,返回索引值
            Console.WriteLine($"从前往后，从第5个字符开始查找【{str1}】中【{str2}】首次出现的位置索引值：{str1.IndexOf(str2, 5)}\r\n");

            // str1.IndexOf(str2, startIndex, endIndex)：从前往后，从第startIndex个字符开始查找endIndex个字符（startIndex + endIndex <= str1.Length），查找字符串中指定字符或字符串首次出现的位置,返回索引值
            Console.WriteLine($"从前往后，从第4个字符开始查找3个字符，查找【{str1}】中【{str2}】首次出现的位置索引值：{str1.IndexOf(str2, 4, 3)}\r\n");

            Console.WriteLine("---------------------反向查找-----------------------");

            // str1.LastIndexOf(str2)：从后往前，查找字符串中指定字符或字符串首次出现的位置,返回索引值
            Console.WriteLine($"从前往后，查找【{str1}】中【{str2}】首次出现的位置索引值：{str1.LastIndexOf(str2)}\r\n");

            // str1.IndexOf(str2, startIndex)：从后往前，从第startIndex个字符开始(查找顺序：startIndex -> 0)查找字符串中指定字符或字符串首次出现的位置,返回索引值
            Console.WriteLine($"从后往前，从第5个字符开始查找【{str1}】中【{str2}】首次出现的位置索引值：{str1.LastIndexOf(str2, 13)}\r\n");

            // str1.IndexOf(str2, startIndex, endIndex)：从后往前，从第startIndex个字符开始查找endIndex个字符（startIndex + endIndex <= str1.Length），查找字符串中指定字符或字符串首次出现的位置,返回索引值
            Console.WriteLine($"从后往前，从第4个字符开始查找3个字符，查找【{str1}】中【{str2}】首次出现的位置索引值：{str1.LastIndexOf(str2, 6, 3)}\r\n");


            Console.WriteLine("---------------------分割字符串-----------------------");

            // str1.Split('B')：根据指定字符分割字符串，返回字符串数组
            Console.Write($"将【{str1}】根据【B】字符(字符需要用单引号，且引号里面只能有单个字符)进行分割：");
            foreach (var item in str1.Split('B')) Console.Write($"{item} ");
            Console.Write("\r\n\r\n");

            // str1.Split("Bb")：根据指定字符串分割字符串，返回字符串数组
            Console.Write($"将【{str1}】根据【Bb】字符串进行分割：");
            foreach (var item in str1.Split("Bb")) Console.Write($"{item} ");
            Console.Write("\r\n\r\n");

            // str1.Split(new char[2] { 'B', 'D' })：根据多个字符分割字符串，返回字符串数组
            Console.Write($"将【{str1}】根据【B】【D】两个字符(字符需要用单引号，且引号里面只能有单个字符)进行分割：");
            foreach (var item in str1.Split(new char[2] { 'B', 'D' })) Console.Write($"{item} ");
            Console.Write("\r\n\r\n");

            // str1.Split(new string[2] { "Bb", "Dd" }, StringSplitOptions.RemoveEmptyEntries)：根据多个字符串分割字符串，返回字符串数组
            Console.Write($"将【{str1}】根据【Bb】【Dd】两个字符串进行分割：");
            foreach (var item in str1.Split(new string[2] { "Bb", "Dd" }, StringSplitOptions.RemoveEmptyEntries)) Console.Write($"{item} ");
            Console.Write("\r\n\r\n");

            Console.WriteLine("---------------------截取字符串-----------------------");

            // str1.Substring(startIndex, length)：提取字符串中的第startIndex个字符开始的长度为length的字符串
            Console.WriteLine($"【{str1}】的第2个字符开始的长度为4的字符串：{str1.Substring(2, 4)}\r\n");

            // str1.Substring(startIndex)：提取字符串中的第startIndex个字符(含)之后的字符串
            Console.WriteLine($"【{str1}】的第5个字符(含)开始之后的字符串：{str1[5..]}\r\n");

            Console.WriteLine("---------------------替换字符串-----------------------");

            // str1.Replace(str2, "RRR")：替换字符串中的特定字符串
            Console.WriteLine($"【{str1}】中的【{str2}】替换为【RRR】：{str1.Replace(str2, "RRR")}\r\n");

            // str1.Replace(str2, "")：删除字符串中的特定字符串
            Console.WriteLine($"删除【{str1}】中的【{str2}】：{str1.Replace(str2, "")}\r\n");

            // str1.Remove(startIndex, length)：删除指定位置(第startIndex个)的指定长度（length）的字符串
            Console.WriteLine($"删除【{str1}】中的第3个(含)长度为3的字符串：{str1.Remove(3, 3)}\r\n");

            // str1.Remove(startIndex)：删除此字符串中从指定位置到最后位置的所有字符
            Console.WriteLine($"删除【{str1}】中的第3个(含)到最后的字符串：{str1.Remove(3)}\r\n");

            Console.WriteLine("---------------------是否包含字符串-----------------------");

            // str1.Contains(str2)等价于SQL中的LIKE '%KEY%'
            // 注意：str1 != null
            Console.WriteLine($"【{str1}】中是否包含【{str2}】：{str1.Contains(str2)}\r\n");

            // str1.EndsWith(str2)等价于SQL中的LIKE '%KEY'
            Console.WriteLine($"【{str1}】中结尾是否包含【cDd】：{str1.EndsWith("cDd")}\r\n");

            // str1.StartsWith(str2)等价于SQL中的LIKE 'KEY%'
            Console.WriteLine($"【{str1}】中开头是否包含【AaB】：{str1.StartsWith("AaB")}\r\n");
        }
    }
}
