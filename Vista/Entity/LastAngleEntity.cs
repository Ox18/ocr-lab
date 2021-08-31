using System;

namespace Vista.Entity
{
    public class LastAngleEntity
    {
        private Boolean change;
        private String angle;
        private Boolean on;

        public LastAngleEntity()
        {
            this.change = false;
            this.angle = "0";
            this.on = false;
        }

        public Boolean getOn()
        {
            return this.on;
        }

        public void setOn(Boolean on)
        {
            this.on = on;
        }

        public Boolean getChange()
        {
            return this.change;
        }

        public String getAngle()
        {
            return this.angle;
        }

        public void setChange(Boolean change)
        {
            this.change = change;
        }

        public void setAngle(String angle)
        {
            this.angle = angle;
        }
    }
}
