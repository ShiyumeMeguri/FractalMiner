using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace IniParser.Parser
{
	public sealed class StringBuffer // TypeDefIndex: 37376
	{
		// Fields
		private static readonly int DefaultCapacity; // 0x00
		private TextReader _dataSource; // 0x10
		private List<char> _buffer; // 0x18
		private Range _bufferIndexes; // 0x20
	
		// Properties
		public int Count { get => default; } // 0x00000001811F0020-0x00000001811F0030 
		// Int32 get_Item4()
		int32_t System::Tuple<System::Object,System::Object,int,int>::get_Item4(
		        Tuple_4_Object_Object_Int32_Int32_ *this,
		        MethodInfo *method)
		{
		  return this->fields.m_Item4;
		}
		
		public bool IsEmpty { get => default; } // 0x0000000185392FE8-0x0000000185392FF0 
		// Boolean get_IsEmpty()
		bool IniParser::Parser::StringBuffer::get_IsEmpty(StringBuffer *this, MethodInfo *method)
		{
		  return this->fields._bufferIndexes._size == 0;
		}
		
		public bool IsWhitespace { get => default; } // 0x00000001835A97E0-0x00000001835A9890 
		// Boolean get_IsWhitespace()
		bool IniParser::Parser::StringBuffer::get_IsWhitespace(StringBuffer *this, MethodInfo *method)
		{
		  int32_t start; // edi
		  int v4; // esi
		  int v5; // eax
		  List_1_System_Char_ *buffer; // rcx
		  uint16_t Item; // bp
		
		  start = this->fields._bufferIndexes._start;
		  v4 = 0;
		  while ( 1 )
		  {
		    v5 = this->fields._bufferIndexes._size <= 0
		       ? 0
		       : this->fields._bufferIndexes._start + this->fields._bufferIndexes._size - 1;
		    if ( start > v5 )
		      break;
		    buffer = this->fields._buffer;
		    if ( !buffer )
		      sub_1800D8260(0LL, method);
		    Item = System::Collections::Generic::List<wchar_t>::get_Item(
		             buffer,
		             start,
		             MethodInfo::System::Collections::Generic::List<wchar_t>::get_Item);
		    if ( !TypeInfo::System::Char->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::System::Char);
		    if ( !System::Char::IsWhiteSpace(Item, 0LL) )
		      break;
		    ++start;
		  }
		  if ( this->fields._bufferIndexes._size > 0 )
		    v4 = this->fields._bufferIndexes._size + this->fields._bufferIndexes._start - 1;
		  return start > v4;
		}
		
		public char this[int idx] { get => default; } // 0x0000000189B32BCC-0x0000000189B32BFC 
		// Char get_Item(Int32)
		// local variable allocation has failed, the output may be wrong!
		uint16_t IniParser::Parser::StringBuffer::get_Item(StringBuffer *this, int32_t idx, MethodInfo *method)
		{
		  if ( !this->fields._buffer )
		    sub_1800D8260(this, *(_QWORD *)&idx);
		  return System::Collections::Generic::List<wchar_t>::get_Item(
		           this->fields._buffer,
		           this->fields._bufferIndexes._start + idx,
		           MethodInfo::System::Collections::Generic::List<wchar_t>::get_Item);
		}
		
	
		// Nested types
		public struct Range // TypeDefIndex: 37375
		{
			// Fields
			private int _start; // 0x00
			private int _size; // 0x04
	
			// Properties
			public int start { get => default; set {} } // 0x0000000182B77620-0x0000000182B77630 0x00000001835A9BE0-0x00000001835A9BF0
			// UInt32 ReadUnaligned[UInt32](Byte ByRef)
			uint32_t System::Runtime::CompilerServices::Unsafe::ReadUnaligned<unsigned int>(uint8_t *source, MethodInfo *method)
			{
			  return *(_DWORD *)source;
			}
			

			// Void set_start(Int32)
			void IniParser::Parser::StringBuffer::Range::set_start(StringBuffer_Range *this, int32_t value, MethodInfo *method)
			{
			  if ( value < 0 )
			    this->_start = 0;
			  else
			    this->_start = value;
			}
			
			public int size { get => default; set {} } // 0x0000000184D88B20-0x0000000184D88B30 0x00000001835A9BD0-0x00000001835A9BE0
			// Int32 get_endIndex()
			int32_t Beyond::Gameplay::Factory::WireRendererInfoCollection<Beyond::Gameplay::Factory::WireRendererInfo>::get_endIndex(
			        WireRendererInfoCollection_1_WireRendererInfo_ *this,
			        MethodInfo *method)
			{
			  return this->m_endIndex;
			}
			

			// Void set_size(Int32)
			void IniParser::Parser::StringBuffer::Range::set_size(StringBuffer_Range *this, int32_t value, MethodInfo *method)
			{
			  if ( value < 0 )
			    this->_size = 0;
			  else
			    this->_size = value;
			}
			
			public int end { get => default; } // 0x00000001835A9B90-0x00000001835A9BB0 
			// Int32 get_end()
			int32_t IniParser::Parser::StringBuffer::Range::get_end(StringBuffer_Range *this, MethodInfo *method)
			{
			  if ( this->_size <= 0 )
			    return 0;
			  else
			    return this->_size + this->_start - 1;
			}
			
			public bool IsEmpty { get => default; } // 0x00000001830D1700-0x00000001830D1710 
			// Boolean get_isEmpty()
			bool UnityEngine::InputSystem::Utilities::MemoryHelpers::BitRegion::get_isEmpty(
			        MemoryHelpers_BitRegion *this,
			        MethodInfo *method)
			{
			  return this->sizeInBits == 0;
			}
			
	
			// Methods
			public void Reset() {} // 0x00000001835A7AA0-0x00000001835A7AB0
			// Void Reset()
			void IniParser::Parser::StringBuffer::Range::Reset(StringBuffer_Range *this, MethodInfo *method)
			{
			  *this = 0LL;
			}
			
			public static Range FromIndexWithSize(int start, int size) => default; // 0x00000001835A9BB0-0x00000001835A9BD0
			// StringBuffer+Range FromIndexWithSize(Int32, Int32)
			StringBuffer_Range IniParser::Parser::StringBuffer::Range::FromIndexWithSize(
			        int32_t start,
			        int32_t size,
			        MethodInfo *method)
			{
			  if ( start < 0 || size <= 0 )
			    return 0LL;
			  else
			    return (StringBuffer_Range)__PAIR64__(size, start);
			}
			
			public static Range WithIndexes(int start, int end) => default; // 0x00000001835A9C80-0x00000001835A9CB0
			// StringBuffer+Range WithIndexes(Int32, Int32)
			StringBuffer_Range IniParser::Parser::StringBuffer::Range::WithIndexes(int32_t start, int32_t end, MethodInfo *method)
			{
			  StringBuffer_Range v4; // [rsp+20h] [rbp+20h]
			
			  if ( start < 0 || end < 0 || end - start < 0 )
			    return 0LL;
			  v4._start = start;
			  v4._size = end - start + 1;
			  return v4;
			}
			
			public override string ToString() => default; // 0x0000000189B321BC-0x0000000189B32250
			// String ToString()
			String *IniParser::Parser::StringBuffer::Range::ToString(StringBuffer_Range *this, MethodInfo *method)
			{
			  Object *v3; // rsi
			  __int64 v4; // rax
			  Object *v5; // rbx
			  Object *v6; // rax
			  int32_t start; // [rsp+40h] [rbp+8h] BYREF
			
			  start = this->_start;
			  v3 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &start);
			  start = IniParser::Parser::StringBuffer::Range::get_end(this, 0LL);
			  v4 = il2cpp_value_box_0(TypeInfo::System::Int32, &start);
			  start = this->_size;
			  v5 = (Object *)v4;
			  v6 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &start);
			  return System::String::Format((String *)"[start:{0}, end:{1} size: {2}]", v3, v5, v6, 0LL);
			}
			
		}
	
		// Constructors
		public StringBuffer() {} // 0x0000000189B32B88-0x0000000189B32BCC
		// StringBuffer()
		void IniParser::Parser::StringBuffer::StringBuffer(StringBuffer *this, MethodInfo *method)
		{
		  struct StringBuffer__Class *v2; // rdx
		
		  v2 = TypeInfo::IniParser::Parser::StringBuffer;
		  if ( !TypeInfo::IniParser::Parser::StringBuffer->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IniParser::Parser::StringBuffer);
		    v2 = TypeInfo::IniParser::Parser::StringBuffer;
		  }
		  IniParser::Parser::StringBuffer::StringBuffer(this, v2->static_fields->DefaultCapacity, 0LL);
		}
		
		public StringBuffer(int capacity) {} // 0x0000000183689AF0-0x0000000183689B50
		// StringBuffer(Int32)
		void IniParser::Parser::StringBuffer::StringBuffer(StringBuffer *this, int32_t capacity, MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Factory_ECSVATFSM_VATFSMProcessor_SetAnimatorParamRequest_ *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  List_1_System_Char_ *v8; // rbx
		  UberPostPassUtils_ColorGradingData **v9; // rdx
		  VolumetricPipelineRT **v10; // r8
		  VolumetricPipelineRT **v11; // r9
		  VolumetricPipelineRT **v12; // [rsp+50h] [rbp+28h]
		  MethodInfo *v13; // [rsp+58h] [rbp+30h]
		
		  v5 = (List_1_Beyond_Gameplay_Factory_ECSVATFSM_VATFSMProcessor_SetAnimatorParamRequest_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<wchar_t>);
		  v8 = (List_1_System_Char_ *)v5;
		  if ( !v5 )
		    sub_1800D8260(v7, v6);
		  System::Collections::Generic::List<Beyond::Gameplay::Factory::ECSVATFSM::VATFSMProcessor::SetAnimatorParamRequest>::List(
		    v5,
		    capacity,
		    MethodInfo::System::Collections::Generic::List<wchar_t>::List);
		  this->fields._buffer = v8;
		  sub_18002D1B0((ParsingException *)&this->fields._buffer, v9, v10, v11, v12, v13);
		}
		
		internal StringBuffer(List<char> buffer, Range bufferIndexes) {} // 0x00000001835A9700-0x00000001835A9720
		static StringBuffer() {} // 0x0000000184D84B60-0x0000000184D84B80
		// StringBuffer()
		void IniParser::Parser::StringBuffer::cctor(MethodInfo *method)
		{
		  TypeInfo::IniParser::Parser::StringBuffer->static_fields->DefaultCapacity = 256;
		}
		
	
		// Methods
		public StringBuffer DiscardChanges() => default; // 0x0000000189B32AA8-0x0000000189B32ADC
		// StringBuffer DiscardChanges()
		StringBuffer *IniParser::Parser::StringBuffer::DiscardChanges(StringBuffer *this, MethodInfo *method)
		{
		  List_1_System_Char_ *buffer; // rdx
		
		  buffer = this->fields._buffer;
		  if ( !buffer )
		    sub_1800D8260(this, 0LL);
		  this->fields._bufferIndexes = IniParser::Parser::StringBuffer::Range::FromIndexWithSize(0, buffer->fields._size, 0LL);
		  return this;
		}
		
		public Range FindSubstring(string subString, int startingIndex = 0 /* Metadata: 0x02302D3C */) => default; // 0x00000001835A9A30-0x00000001835A9B90
		// StringBuffer+Range FindSubstring(String, Int32)
		StringBuffer_Range IniParser::Parser::StringBuffer::FindSubstring(
		        StringBuffer *this,
		        String *subString,
		        int32_t startingIndex,
		        MethodInfo *method)
		{
		  String *v4; // r14
		  StringBuffer *v5; // rsi
		  int stringLength; // r13d
		  int v7; // edi
		  __int64 v8; // r8
		  int v9; // ebp
		  StringBuffer_Range v10; // rbx
		  int v11; // eax
		  List_1_System_Char_ *buffer; // rax
		  int v13; // eax
		  unsigned int v14; // r15d
		  uint16_t *p_firstChar; // r12
		  uint16_t Item; // ax
		  int v17; // edi
		
		  v4 = subString;
		  v5 = this;
		  if ( !subString )
		LABEL_26:
		    sub_1800D8260(this, subString);
		  stringLength = subString->fields._stringLength;
		  if ( stringLength <= 0 || this->fields._bufferIndexes._size < stringLength )
		    return 0LL;
		  v7 = startingIndex + this->fields._bufferIndexes._start;
		  LODWORD(v8) = subString->fields._stringLength;
		  v9 = v7 + stringLength - 1;
		  v10 = 0LL;
		  while ( 1 )
		  {
		    v11 = v5->fields._bufferIndexes._size <= 0
		        ? 0
		        : v5->fields._bufferIndexes._size + v5->fields._bufferIndexes._start - 1;
		    if ( v7 > v11 )
		      return v10;
		    buffer = v5->fields._buffer;
		    if ( !buffer )
		      goto LABEL_26;
		    if ( (unsigned int)v7 >= buffer->fields._size )
		      System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		    subString = (String *)buffer->fields._items;
		    if ( !subString )
		      goto LABEL_26;
		    if ( (unsigned int)v7 >= LODWORD(subString[1].klass) )
		      sub_1800D2AB0(this, subString);
		    if ( (int)v8 <= 0 )
		LABEL_27:
		      System::ThrowHelper::ThrowIndexOutOfRangeException(0LL);
		    this = (StringBuffer *)v7;
		    if ( *((_WORD *)&subString[1].monitor + v7) == v4->fields._firstChar )
		    {
		      if ( v5->fields._bufferIndexes._size <= 0 )
		        v13 = 0;
		      else
		        v13 = v5->fields._bufferIndexes._size + v5->fields._bufferIndexes._start - 1;
		      if ( v9 <= v13 )
		      {
		        v14 = 0;
		        p_firstChar = &v4->fields._firstChar;
		        do
		        {
		          this = (StringBuffer *)v5->fields._buffer;
		          if ( !this )
		            goto LABEL_26;
		          Item = System::Collections::Generic::List<wchar_t>::get_Item(
		                   (List_1_System_Char_ *)this,
		                   v14 + v7,
		                   MethodInfo::System::Collections::Generic::List<wchar_t>::get_Item);
		          v8 = v4->fields._stringLength;
		          this = (StringBuffer *)v14;
		          if ( v14 >= v8 )
		            goto LABEL_27;
		          if ( Item != *p_firstChar )
		            goto LABEL_14;
		          ++v14;
		          ++p_firstChar;
		        }
		        while ( (int)v14 < stringLength );
		        v17 = v7 - v5->fields._bufferIndexes._start;
		        if ( v17 >= 0 )
		          return (StringBuffer_Range)__PAIR64__(stringLength, v17);
		      }
		      return v10;
		    }
		LABEL_14:
		    ++v7;
		    ++v9;
		  }
		}
		
		public bool ReadLine() => default; // 0x00000001835A9390-0x00000001835A9470
		// Boolean ReadLine()
		bool IniParser::Parser::StringBuffer::ReadLine(StringBuffer *this, MethodInfo *method)
		{
		  List_1_System_Char_ *buffer; // rcx
		  StringBuffer_Range v4; // rbx
		  int i; // eax
		  int size; // edx
		
		  if ( !this->fields._dataSource )
		    return 0;
		  buffer = this->fields._buffer;
		  if ( !buffer )
		    goto LABEL_18;
		  ++buffer->fields._version;
		  v4 = 0LL;
		  buffer->fields._size = 0;
		  method = (MethodInfo *)this->fields._dataSource;
		  if ( !method )
		    goto LABEL_18;
		  for ( i = sub_180002F70(10LL, method); i != 10; i = sub_180002F70(10LL, method) )
		  {
		    if ( i != 13 )
		    {
		      if ( i == -1 )
		        break;
		      buffer = this->fields._buffer;
		      if ( !buffer )
		        goto LABEL_18;
		      sub_183C326B0(buffer, (unsigned __int16)i, MethodInfo::System::Collections::Generic::List<wchar_t>::Add);
		    }
		    method = (MethodInfo *)this->fields._dataSource;
		    if ( !method )
		      goto LABEL_18;
		  }
		  buffer = this->fields._buffer;
		  if ( !buffer )
		LABEL_18:
		    sub_1800D8260(buffer, method);
		  size = buffer->fields._size;
		  if ( size > 0 )
		    v4 = (StringBuffer_Range)__PAIR64__(size, 0);
		  this->fields._bufferIndexes = v4;
		  return buffer->fields._size > 0 || i != -1;
		}
		
		public void Reset(TextReader dataSource) {} // 0x00000001835A7A60-0x00000001835A7AA0
		public void Resize(Range range) {} // 0x00000001835A9720-0x00000001835A9770
		// Void Resize(StringBuffer+Range)
		void IniParser::Parser::StringBuffer::Resize(StringBuffer *this, StringBuffer_Range range, MethodInfo *method)
		{
		  int32_t start; // eax
		  int32_t v4; // r10d
		  int v5; // r9d
		
		  if ( range._start >= 0 && range._size >= 0 )
		  {
		    start = this->fields._bufferIndexes._start;
		    v4 = 0;
		    v5 = range._start + start;
		    range._start = this->fields._bufferIndexes._size <= 0 ? 0 : start + this->fields._bufferIndexes._size - 1;
		    if ( v5 + range._size - 1 <= range._start )
		    {
		      if ( v5 >= 0 )
		        v4 = v5;
		      this->fields._bufferIndexes._start = v4;
		      this->fields._bufferIndexes._size = range._size;
		    }
		  }
		}
		
		public void Resize(int newSize) {} // 0x0000000189B32ADC-0x0000000189B32AEC
		// Void Resize(Int32)
		void IniParser::Parser::StringBuffer::Resize(StringBuffer *this, int32_t newSize, MethodInfo *method)
		{
		  IniParser::Parser::StringBuffer::Resize(this, 0, newSize, 0LL);
		}
		
		public void Resize(int startIdx, int size) {} // 0x00000001835A9790-0x00000001835A97E0
		// Void Resize(Int32, Int32)
		void IniParser::Parser::StringBuffer::Resize(StringBuffer *this, int32_t startIdx, int32_t size, MethodInfo *method)
		{
		  int32_t start; // eax
		  int32_t v5; // r10d
		  int v6; // r9d
		  int v7; // edx
		
		  if ( startIdx >= 0 && size >= 0 )
		  {
		    start = this->fields._bufferIndexes._start;
		    v5 = 0;
		    v6 = startIdx + start;
		    v7 = this->fields._bufferIndexes._size <= 0 ? 0 : start + this->fields._bufferIndexes._size - 1;
		    if ( v6 + size - 1 <= v7 )
		    {
		      if ( v6 >= 0 )
		        v5 = v6;
		      this->fields._bufferIndexes._start = v5;
		      this->fields._bufferIndexes._size = size;
		    }
		  }
		}
		
		public void ResizeBetweenIndexes(int startIdx, int endIdx) {} // 0x00000001835A81D0-0x00000001835A8220
		// Void ResizeBetweenIndexes(Int32, Int32)
		void IniParser::Parser::StringBuffer::ResizeBetweenIndexes(
		        StringBuffer *this,
		        int32_t startIdx,
		        int32_t endIdx,
		        MethodInfo *method)
		{
		  int32_t v4; // r8d
		  int32_t start; // eax
		  int32_t v6; // r10d
		  int v7; // r9d
		  int v8; // edx
		
		  v4 = endIdx - startIdx + 1;
		  if ( startIdx >= 0 && v4 >= 0 )
		  {
		    start = this->fields._bufferIndexes._start;
		    v6 = 0;
		    v7 = startIdx + start;
		    v8 = this->fields._bufferIndexes._size <= 0 ? 0 : start + this->fields._bufferIndexes._size - 1;
		    if ( v7 + v4 - 1 <= v8 )
		    {
		      if ( v7 >= 0 )
		        v6 = v7;
		      this->fields._bufferIndexes._start = v6;
		      this->fields._bufferIndexes._size = v4;
		    }
		  }
		}
		
		public StringBuffer Substring(Range range) => default; // 0x00000001835A9670-0x00000001835A96B0
		// StringBuffer Substring(StringBuffer+Range)
		StringBuffer *IniParser::Parser::StringBuffer::Substring(
		        StringBuffer *this,
		        StringBuffer_Range range,
		        MethodInfo *method)
		{
		  StringBuffer *v4; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  StringBuffer *v7; // rdi
		
		  v4 = IniParser::Parser::StringBuffer::SwallowCopy(this, 0LL);
		  v7 = v4;
		  if ( !v4 )
		    sub_1800D8260(v6, v5);
		  IniParser::Parser::StringBuffer::Resize(v4, range, 0LL);
		  return v7;
		}
		
		public StringBuffer SwallowCopy() => default; // 0x00000001835A96B0-0x00000001835A9700
		public void TrimStart() {} // 0x00000001835A9950-0x00000001835A9A30
		// Void TrimStart()
		void IniParser::Parser::StringBuffer::TrimStart(StringBuffer *this, MethodInfo *method)
		{
		  StringBuffer *v2; // rbx
		  int32_t start; // edi
		  int32_t v4; // ebp
		  int v5; // eax
		  List_1_System_Char_ *buffer; // rax
		  uint16_t v7; // si
		  int v8; // eax
		  int32_t v9; // ecx
		  int v10; // eax
		
		  v2 = this;
		  if ( this->fields._bufferIndexes._size )
		  {
		    start = this->fields._bufferIndexes._start;
		    v4 = 0;
		    while ( 1 )
		    {
		      v5 = v2->fields._bufferIndexes._size <= 0
		         ? 0
		         : v2->fields._bufferIndexes._start + v2->fields._bufferIndexes._size - 1;
		      if ( start > v5 )
		        break;
		      buffer = v2->fields._buffer;
		      if ( !buffer )
		        goto LABEL_22;
		      if ( (unsigned int)start >= buffer->fields._size )
		        System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		      this = (StringBuffer *)buffer->fields._items;
		      if ( !this )
		LABEL_22:
		        sub_1800D8260(this, method);
		      if ( (unsigned int)start >= LODWORD(this->fields._buffer) )
		        sub_1800D2AB0(this, method);
		      v7 = *((_WORD *)&this->fields._bufferIndexes._start + start);
		      if ( !TypeInfo::System::Char->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::System::Char);
		      if ( !System::Char::IsWhiteSpace(v7, 0LL) )
		        break;
		      ++start;
		    }
		    if ( v2->fields._bufferIndexes._size <= 0 )
		      v8 = 0;
		    else
		      v8 = v2->fields._bufferIndexes._size + v2->fields._bufferIndexes._start - 1;
		    if ( start < 0 )
		      v9 = 0;
		    else
		      v9 = start;
		    v2->fields._bufferIndexes._start = v9;
		    v10 = v8 - start + 1;
		    if ( v10 >= 0 )
		      v4 = v10;
		    v2->fields._bufferIndexes._size = v4;
		  }
		}
		
		public void TrimEnd() {} // 0x00000001835A9890-0x00000001835A9950
		// Void TrimEnd()
		void IniParser::Parser::StringBuffer::TrimEnd(StringBuffer *this, MethodInfo *method)
		{
		  StringBuffer *v2; // rdi
		  int32_t v3; // ebp
		  int32_t v4; // ebx
		  List_1_System_Char_ *buffer; // rax
		  uint16_t v6; // si
		  int v7; // ebx
		
		  v2 = this;
		  if ( this->fields._bufferIndexes._size )
		  {
		    v3 = 0;
		    if ( this->fields._bufferIndexes._size <= 0 )
		      v4 = 0;
		    else
		      v4 = this->fields._bufferIndexes._size + this->fields._bufferIndexes._start - 1;
		    if ( v4 >= this->fields._bufferIndexes._start )
		    {
		      do
		      {
		        buffer = v2->fields._buffer;
		        if ( !buffer )
		          goto LABEL_18;
		        if ( (unsigned int)v4 >= buffer->fields._size )
		          System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		        this = (StringBuffer *)buffer->fields._items;
		        if ( !this )
		LABEL_18:
		          sub_1800D8260(this, method);
		        if ( (unsigned int)v4 >= LODWORD(this->fields._buffer) )
		          sub_1800D2AB0(this, method);
		        v6 = *((_WORD *)&this->fields._bufferIndexes._start + v4);
		        if ( !TypeInfo::System::Char->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::System::Char);
		        if ( !System::Char::IsWhiteSpace(v6, 0LL) )
		          break;
		        --v4;
		      }
		      while ( v4 >= v2->fields._bufferIndexes._start );
		    }
		    v7 = v4 - v2->fields._bufferIndexes._start + 1;
		    if ( v7 >= 0 )
		      v3 = v7;
		    v2->fields._bufferIndexes._size = v3;
		  }
		}
		
		public void Trim() {} // 0x00000001835A9770-0x00000001835A9790
		// Void Trim()
		void IniParser::Parser::StringBuffer::Trim(StringBuffer *this, MethodInfo *method)
		{
		  IniParser::Parser::StringBuffer::TrimEnd(this, 0LL);
		  IniParser::Parser::StringBuffer::TrimStart(this, 0LL);
		}
		
		public bool StartsWith(string str) => default; // 0x00000001835A8E20-0x00000001835A8ED0
		// Boolean StartsWith(String)
		bool IniParser::Parser::StringBuffer::StartsWith(StringBuffer *this, String *str, MethodInfo *method)
		{
		  int32_t start; // r15d
		  uint16_t *p_firstChar; // r14
		  int32_t i; // esi
		  List_1_System_Char_ *buffer; // rcx
		  uint16_t v9; // bp
		
		  if ( !str || !str->fields._stringLength || !this->fields._bufferIndexes._size )
		    return 0;
		  start = this->fields._bufferIndexes._start;
		  p_firstChar = &str->fields._firstChar;
		  for ( i = 0; i < str->fields._stringLength; ++i )
		  {
		    if ( (unsigned int)i >= (__int64)str->fields._stringLength )
		      System::ThrowHelper::ThrowIndexOutOfRangeException(0LL);
		    buffer = this->fields._buffer;
		    if ( !buffer )
		      sub_1800D8260(0LL, str);
		    v9 = *p_firstChar;
		    if ( v9 != System::Collections::Generic::List<wchar_t>::get_Item(
		                 buffer,
		                 start,
		                 MethodInfo::System::Collections::Generic::List<wchar_t>::get_Item) )
		      return 0;
		    ++p_firstChar;
		    ++start;
		  }
		  return 1;
		}
		
		public override string ToString() => default; // 0x00000001840C1F60-0x00000001840C1FA0
		// String ToString()
		String *IniParser::Parser::StringBuffer::ToString(StringBuffer *this, MethodInfo *method)
		{
		  List_1_System_Char_ *buffer; // rcx
		  Char__Array *v4; // rax
		
		  buffer = this->fields._buffer;
		  if ( !buffer )
		    sub_1800D8260(0LL, method);
		  v4 = (Char__Array *)System::Collections::Generic::List<UnityEngine::InputSystem::HID::HID::HIDElementDescriptor>::ToArray(
		                        (List_1_UnityEngine_InputSystem_HID_HID_HIDElementDescriptor_ *)buffer,
		                        MethodInfo::System::Collections::Generic::List<wchar_t>::ToArray);
		  return System::String::Ctor(v4, this->fields._bufferIndexes._start, this->fields._bufferIndexes._size, 0LL);
		}
		
		public string ToString(Range range) => default; // 0x0000000189B32AEC-0x0000000189B32B88
		// String ToString(StringBuffer+Range)
		String *IniParser::Parser::StringBuffer::ToString(StringBuffer *this, StringBuffer_Range range, MethodInfo *method)
		{
		  int32_t start; // ebx
		  int32_t end; // eax
		  __int64 v6; // rdx
		  List_1_System_Char_ *buffer; // rcx
		  Char__Array *v8; // rax
		  int32_t size; // [rsp+4Ch] [rbp+14h]
		
		  size = range._size;
		  start = range._start;
		  if ( !range._size )
		    return TypeInfo::System::String->static_fields->Empty;
		  if ( range._start < 0 )
		    return TypeInfo::System::String->static_fields->Empty;
		  if ( range._size > this->fields._bufferIndexes._size )
		    return TypeInfo::System::String->static_fields->Empty;
		  end = IniParser::Parser::StringBuffer::Range::get_end(&this->fields._bufferIndexes, 0LL);
		  v6 = (unsigned int)(start + this->fields._bufferIndexes._start);
		  if ( (int)v6 > end )
		    return TypeInfo::System::String->static_fields->Empty;
		  buffer = this->fields._buffer;
		  if ( !buffer )
		    sub_1800D8260(0LL, v6);
		  v8 = (Char__Array *)System::Collections::Generic::List<UnityEngine::InputSystem::HID::HID::HIDElementDescriptor>::ToArray(
		                        (List_1_UnityEngine_InputSystem_HID_HID_HIDElementDescriptor_ *)buffer,
		                        MethodInfo::System::Collections::Generic::List<wchar_t>::ToArray);
		  return System::String::CreateString(0LL, v8, start + this->fields._bufferIndexes._start, size, 0LL);
		}
		
	}
}
