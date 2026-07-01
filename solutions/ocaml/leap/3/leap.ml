let leap_year year = 
    let divisible_by_4 = year mod 4 = 0 in
    let divisible_by_100 = year mod 100 = 0 in
    let divisible_by_400 = year mod 400 = 0 in
    if divisible_by_4 then
        if divisible_by_100 then 
            divisible_by_400
        else true
    else false
