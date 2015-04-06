#ifndef _IDATA_STORAGE_H_
#define _IDATA_STORAGE_H_

#include "General.h"

class IDataStorage
{
public:
	IDataStorage();

	virtual dword ReadFromStorage(byte* buffer, dword bufferSize) = 0;

	~IDataStorage();

private:

};

IDataStorage::IDataStorage()
{
}

IDataStorage::~IDataStorage()
{
}

#endif