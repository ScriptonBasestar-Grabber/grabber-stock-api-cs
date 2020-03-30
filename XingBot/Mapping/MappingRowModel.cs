using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace XingBot.Mapping
{
    class MappingRowModel
    {
        public MappingRowModel(MappingFieldModel[] inBlocks, MappingFieldModel[] outBlocks)
        {
            this.InBlocks = inBlocks;
            this.OutBlocks = outBlocks;
        }

        public MappingFieldModel[] InBlocks { get; private set; }
        public MappingFieldModel[] OutBlocks { get; private set; }
    }

    class MappingRowModelBuilder
    {
        private readonly List<MappingFieldModel> _inBlock = new List<MappingFieldModel>();
        private readonly List<MappingFieldModel> _outBlock = new List<MappingFieldModel>();

        public static MappingRowModelBuilder Create()
        {
            return new MappingRowModelBuilder();
        }

        public MappingRowModelBuilder InBlock(params MappingFieldModel[] inBlocks)
        {
            foreach (var inBlock in inBlocks)
            {
                this._inBlock.Add(inBlock);
            }

            return this;
        }

        public MappingRowModelBuilder InBlock(string fieldName, Type fieldType)
        {
            this._inBlock.Add(new MappingFieldModel(fieldName, fieldType));
            return this;
        }

        public MappingRowModelBuilder InBlock(params Tuple<string, Type>[] tuples)
        {
            foreach (var tuple in tuples)
            {
                this._inBlock.Add(new MappingFieldModel(tuple.Item1, tuple.Item2));
            }

            return this;
        }

        public MappingRowModelBuilder OutBlock(params MappingFieldModel[] outBlocks)
        {
            foreach (var outBlock in _outBlock)
            {
                this._outBlock.Add(outBlock);
            }

            return this;
        }

        public MappingRowModelBuilder OutBlock(string fieldName, Type fieldType)
        {
            this._outBlock.Add(new MappingFieldModel(fieldName, fieldType));
            return this;
        }

        public MappingRowModelBuilder OutBlock(params Tuple<string, Type>[] tuples)
        {
            foreach (var tuple in tuples)
            {
                this._outBlock.Add(new MappingFieldModel(tuple.Item1, tuple.Item2));
            }

            return this;
        }

        public MappingRowModel Build()
        {
            return new MappingRowModel(_inBlock.ToArray(), _outBlock.ToArray());
        }
    }
}