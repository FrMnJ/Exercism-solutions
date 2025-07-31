#include "space_age.h"

namespace space_age {
    space_age::space_age(long long seconds){
        this->seconds_lived = seconds;
    }
    
    long long space_age::seconds() const{
        return this->seconds_lived;
    }

    double space_age::on_earth() const{
        return this->seconds_lived/31'557'600.0;
    }

    double space_age::on_mercury() const{
        return this->seconds_lived/(31'557'600.0*0.240'846'7);
    }

    double space_age::on_venus() const{
         return this->seconds_lived/(31'557'600.0*0.615'197'26);
    }

    double space_age::on_mars() const{
        return this->seconds_lived/(31'557'600.0*1.880'815'8);
    }

    double space_age::on_jupiter() const{
        return this->seconds_lived/(31'557'600.0*11.862'615);
    }

    double space_age::on_saturn() const{
        return this->seconds_lived/(31'557'600.0*29.447'498);
    }

    double space_age::on_uranus() const{
        return this->seconds_lived/(31'557'600.0*84.016'846);
    }

    double space_age::on_neptune() const{
        return this->seconds_lived/(31'557'600.0*164.791'32);
    }
}  // namespace space_age
