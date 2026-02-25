using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

class Seat
{
    public static int _totalCount;
    public static int _currentSeat;
    
    public string _name;
    private int _seatId;
    

    public Seat(string name)
    {
        _name = name;
        _totalCount++;
        _seatId = _totalCount;
        Console.WriteLine($"좌석 {_seatId}번 착석: {_name}");
        
        _currentSeat++;
    }

    public void Study()
    {
        Console.WriteLine($"{_name}이(가) 좌석 {_seatId}번에서 공부 중...");
    }


    public static void ShowStatus()
    {
        Console.WriteLine($"총 이용: {_totalCount}명, 현재 착석: {_currentSeat}명");
    }
    ~Seat()
    {
        Console.WriteLine($"좌석 {_seatId}번 반납: {_name}");
        _currentSeat--;
    }

}