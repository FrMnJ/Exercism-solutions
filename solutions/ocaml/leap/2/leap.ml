let leap_year year = 
    if year mod 4 = 0 then
        if year mod 100 = 0 then 
            year mod 400 = 0
        else true
    else false
