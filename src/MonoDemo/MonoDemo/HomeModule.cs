using System;
using System.Text;
using Nancy;

namespace MonoDemo
{
    public class HomeModule : NancyModule
    {
        public HomeModule ()
        {
            Get["/"] = p => Response.AsText("Hello World");

            Get["/info"] = p => {
                var vars = Environment.GetEnvironmentVariables();
                var sb = new StringBuilder("System Information");
                var lineSeperator = string.Format("{0}~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~{0}", Environment.NewLine);
                sb.AppendLine(lineSeperator);
                foreach(var k in vars.Keys) {
                    var v = vars[k];
                    if (v != null) {
                        sb.AppendFormat("{0} = {1}{2}", k, v, Environment.NewLine);
                    } else {
                        sb.AppendFormat("{0} = {1}{2}", k, "N/A", Environment.NewLine);
                    }
                }
                sb.AppendLine(lineSeperator);
                return Response.AsText(sb.ToString());
            };
        }
    }
}