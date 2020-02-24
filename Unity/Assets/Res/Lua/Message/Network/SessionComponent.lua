-- Generated by CSharp.lua Compiler
local System = System
local DCET = DCET
System.namespace("DCET", function (namespace)
  namespace.class("SessionComponentAwakeSystem", function (namespace)
    local Awake
    Awake = function (this, self)
      self:Awake()
    end
    return {
      base = function (out)
        return {
          out.DCET.AwakeSystem_1(out.DCET.SessionComponent)
        }
      end,
      Awake = Awake,
      __metadata__ = function (out)
        return {
          class = { 0x6, out.DCET.ObjectSystemAttribute() }
        }
      end
    }
  end)

  namespace.class("SessionComponent", function (namespace)
    local getSession, setSession, Awake, Dispose, class, __ctor__
    __ctor__ = function (this)
      DCET.Entity.__ctor__(this)
    end
    getSession = function (this)
      return this.session
    end
    setSession = function (this, value)
      if this.session ~= nil and not this.session:getIsDisposed() then
        this.session:Dispose()
      end

      this.session = value
    end
    Awake = function (this)
      class.Instance = this
    end
    Dispose = function (this)
      if this:getIsDisposed() then
        return
      end

      DCET.Entity.Dispose(this)

      getSession(this):Dispose()
      setSession(this, nil)
      class.Instance = nil
    end
    class = {
      base = function (out)
        return {
          out.DCET.Entity
        }
      end,
      getSession = getSession,
      setSession = setSession,
      Awake = Awake,
      Dispose = Dispose,
      __ctor__ = __ctor__
    }
    return class
  end)
end)