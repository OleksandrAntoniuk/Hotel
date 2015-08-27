﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel.Service.DTOs
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientDTO", Namespace="http://schemas.datacontract.org/2004/07/Hotel.Service.DTOs")]
    public partial class ClientDTO : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string EmailField;
        
        private string FirstNameField;
        
        private int IdField;
        
        private string LastNameField;
        
        private string PhoneField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone
        {
            get
            {
                return this.PhoneField;
            }
            set
            {
                this.PhoneField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HotelDTO", Namespace="http://schemas.datacontract.org/2004/07/Hotel.Service.DTOs")]
    public partial class HotelDTO : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private string NameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoomDTO", Namespace="http://schemas.datacontract.org/2004/07/Hotel.Service.DTOs")]
    public partial class RoomDTO : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private bool ApprovedField;
        
        private int ClientIdField;
        
        private int HotelIdField;
        
        private int IdField;
        
        private string NameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Approved
        {
            get
            {
                return this.ApprovedField;
            }
            set
            {
                this.ApprovedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ClientId
        {
            get
            {
                return this.ClientIdField;
            }
            set
            {
                this.ClientIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HotelId
        {
            get
            {
                return this.HotelIdField;
            }
            set
            {
                this.HotelIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IHotelService")]
public interface IHotelService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetClients", ReplyAction="http://tempuri.org/IHotelService/GetClientsResponse")]
    Hotel.Service.DTOs.ClientDTO[] GetClients();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetClients", ReplyAction="http://tempuri.org/IHotelService/GetClientsResponse")]
    System.Threading.Tasks.Task<Hotel.Service.DTOs.ClientDTO[]> GetClientsAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetHotels", ReplyAction="http://tempuri.org/IHotelService/GetHotelsResponse")]
    Hotel.Service.DTOs.HotelDTO[] GetHotels();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetHotels", ReplyAction="http://tempuri.org/IHotelService/GetHotelsResponse")]
    System.Threading.Tasks.Task<Hotel.Service.DTOs.HotelDTO[]> GetHotelsAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetRooms", ReplyAction="http://tempuri.org/IHotelService/GetRoomsResponse")]
    Hotel.Service.DTOs.RoomDTO[] GetRooms(int hotelId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetRooms", ReplyAction="http://tempuri.org/IHotelService/GetRoomsResponse")]
    System.Threading.Tasks.Task<Hotel.Service.DTOs.RoomDTO[]> GetRoomsAsync(int hotelId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetHotelId", ReplyAction="http://tempuri.org/IHotelService/GetHotelIdResponse")]
    int GetHotelId(string hotelName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetHotelId", ReplyAction="http://tempuri.org/IHotelService/GetHotelIdResponse")]
    System.Threading.Tasks.Task<int> GetHotelIdAsync(string hotelName);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetClientId", ReplyAction="http://tempuri.org/IHotelService/GetClientIdResponse")]
    int GetClientId(string email);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetClientId", ReplyAction="http://tempuri.org/IHotelService/GetClientIdResponse")]
    System.Threading.Tasks.Task<int> GetClientIdAsync(string email);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/InsertClient", ReplyAction="http://tempuri.org/IHotelService/InsertClientResponse")]
    void InsertClient(Hotel.Service.DTOs.ClientDTO client);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/InsertClient", ReplyAction="http://tempuri.org/IHotelService/InsertClientResponse")]
    System.Threading.Tasks.Task InsertClientAsync(Hotel.Service.DTOs.ClientDTO client);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/InsertRoom", ReplyAction="http://tempuri.org/IHotelService/InsertRoomResponse")]
    void InsertRoom(Hotel.Service.DTOs.RoomDTO room);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/InsertRoom", ReplyAction="http://tempuri.org/IHotelService/InsertRoomResponse")]
    System.Threading.Tasks.Task InsertRoomAsync(Hotel.Service.DTOs.RoomDTO room);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IHotelServiceChannel : IHotelService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class HotelServiceClient : System.ServiceModel.ClientBase<IHotelService>, IHotelService
{
    
    public HotelServiceClient()
    {
    }
    
    public HotelServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public HotelServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public HotelServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public HotelServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public Hotel.Service.DTOs.ClientDTO[] GetClients()
    {
        return base.Channel.GetClients();
    }
    
    public System.Threading.Tasks.Task<Hotel.Service.DTOs.ClientDTO[]> GetClientsAsync()
    {
        return base.Channel.GetClientsAsync();
    }
    
    public Hotel.Service.DTOs.HotelDTO[] GetHotels()
    {
        return base.Channel.GetHotels();
    }
    
    public System.Threading.Tasks.Task<Hotel.Service.DTOs.HotelDTO[]> GetHotelsAsync()
    {
        return base.Channel.GetHotelsAsync();
    }
    
    public Hotel.Service.DTOs.RoomDTO[] GetRooms(int hotelId)
    {
        return base.Channel.GetRooms(hotelId);
    }
    
    public System.Threading.Tasks.Task<Hotel.Service.DTOs.RoomDTO[]> GetRoomsAsync(int hotelId)
    {
        return base.Channel.GetRoomsAsync(hotelId);
    }
    
    public int GetHotelId(string hotelName)
    {
        return base.Channel.GetHotelId(hotelName);
    }
    
    public System.Threading.Tasks.Task<int> GetHotelIdAsync(string hotelName)
    {
        return base.Channel.GetHotelIdAsync(hotelName);
    }
    
    public int GetClientId(string email)
    {
        return base.Channel.GetClientId(email);
    }
    
    public System.Threading.Tasks.Task<int> GetClientIdAsync(string email)
    {
        return base.Channel.GetClientIdAsync(email);
    }
    
    public void InsertClient(Hotel.Service.DTOs.ClientDTO client)
    {
        base.Channel.InsertClient(client);
    }
    
    public System.Threading.Tasks.Task InsertClientAsync(Hotel.Service.DTOs.ClientDTO client)
    {
        return base.Channel.InsertClientAsync(client);
    }
    
    public void InsertRoom(Hotel.Service.DTOs.RoomDTO room)
    {
        base.Channel.InsertRoom(room);
    }
    
    public System.Threading.Tasks.Task InsertRoomAsync(Hotel.Service.DTOs.RoomDTO room)
    {
        return base.Channel.InsertRoomAsync(room);
    }
}
