﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;
using Newtonsoft.Json;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WeatherService" in code, svc and config file together.
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WeatherService" in code, svc and config file together.
public class WeatherService : IWeatherService
{
    public WeatherReports getWeatherData(string city_name, string state_name)
    {
        string key = "4b47e918045b2342";
        string output;
        WeatherReports wp = new WeatherReports();

        using (WebClient client = new WebClient())
        {
            string input = "http://api.wunderground.com/api/" + key + "/conditions/q/" + state_name + "/" + city_name + ".json";
            output = client.DownloadString(input);
            wp = JsonConvert.DeserializeObject<WeatherReports>(output);

            wp.current_observation.weather = "Not Available now";
            return wp;
        }
    }

    public double AreaSquare(double sides)
    {
        return sides * sides;
    }

    public double AreaRectangle(double length, double breadth)
    {
        return length * breadth;
    }
    public double GetSpeed(double distance, double time)
    {
        return distance / time;
    }
    public double GetDistance(double speed, double time)
    {
        return speed * time;
    }
    public double GetTime(double distance, double speed)
    {
        return distance * speed;
    }
    public string Concat(string firtname, string lastname)
    {
        return firtname + " " + lastname;
    }
    public int Add(int value1, int value2)
    {
        return value1 + value2;
    }
    public int Multiply(int value1, int value2)
    {
        return value1 * value2;
    }
    public int Divide(int value1, int value2)
    {
        return value1 / value2;
    }
    public int Modulus(int value1, int value2)
    {
        return value1 % value2;
    }
    public int Sum(int value)
    {
        return value * 2;
    }
}
