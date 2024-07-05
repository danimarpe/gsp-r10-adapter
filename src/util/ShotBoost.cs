using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gspro_r10
{
    public static class ShotBoost
    {

        public static double Boost(IConfigurationSection configuration, double shot)
        {
            double amount = double.Parse(configuration["shotBoost"] ?? "1", CultureInfo.InvariantCulture);
            if (amount > 0)
            {
                amount += (shot / 1000);
                shot = shot * amount;
            }
            return shot;
        }
    }
}
