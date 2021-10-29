using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem_lab3
{
    enum ConnectionTypeEnum
    {
        SCSI,
        SAS,
        Firewire,
        IDE,
        SATA
    }
    class HardDrive: MemoryStorage
    {
        private ConnectionTypeEnum connectionType;

        public HardDrive(int volume_gb, int speed, ConnectionTypeEnum connectionTypeEnum)
            :base(volume_gb, speed)
        {  
            this.connectionType = connectionTypeEnum;
        }

        
        public ConnectionTypeEnum ConnectionType => connectionType;

    }
}
