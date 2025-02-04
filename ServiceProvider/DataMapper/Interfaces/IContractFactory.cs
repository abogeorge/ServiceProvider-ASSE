﻿using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMapper.Implementation
{
    public interface IContractFactory
    {
        void AddContract(Contract contract, Customer customer, Subscription subscription);
        Contract GetContractByName(String contractName);
        void UpdateContractPrice(Contract contract);
        void UpdateContractEndDate(Contract contract);
        void DropContractByName(Contract contract, Customer customer, Subscription subscription);
    }
}
