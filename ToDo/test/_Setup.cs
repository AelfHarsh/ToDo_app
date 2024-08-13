﻿using AElf.Cryptography.ECDSA;
using AElf.Testing.TestBase;

namespace AElf.Contracts.ToDO
{
    // The Module class load the context required for unit testing
    public class Module : ContractTestModule<ToDO>
    {
        
    }
    
    // The TestBase class inherit ContractTestBase class, it defines Stub classes and gets instances required for unit testing
    public class TestBase : ContractTestBase<Module>
    {
        // The Stub class for unit testing
        internal readonly ToDOContainer.ToDOStub ToDOStub;
        // A key pair that can be used to interact with the contract instance
        private ECKeyPair DefaultKeyPair => Accounts[0].KeyPair;

        public TestBase()
        {
            ToDOStub = GetToDOContractStub(DefaultKeyPair);
        }

        private ToDOContainer.ToDOStub GetToDOContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<ToDOContainer.ToDOStub>(ContractAddress, senderKeyPair);
        }
    }
    
}